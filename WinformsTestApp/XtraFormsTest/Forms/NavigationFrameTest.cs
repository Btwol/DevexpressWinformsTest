using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraCharts.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using XtraFormsTest.Services;
using XtraFormsTest.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace XtraFormsTest.Forms
{
    public partial class NavigationFrameTest : DevExpress.XtraEditors.XtraForm
    {
        private readonly GridViewTest gridViewTest;
        private readonly TextManipulationView textManipulationView;
        private readonly TableLayoutPanelTest tableLayoutPanelTest;
        private readonly ILocalisationProvider localisationProvider;

        public NavigationFrameTest(Func<GridViewTest> gridViewTestFactory,
            Func<TextManipulationView> textManipulationViewFactory,
            Func<TableLayoutPanelTest> tableLayoutPanelTestFactory,
            ILocalisationProvider localisationProvider)
        {
            InitializeComponent();
            this.localisationProvider = localisationProvider;
            gridViewTest = gridViewTestFactory();
            textManipulationView = textManipulationViewFactory();
            tableLayoutPanelTest = tableLayoutPanelTestFactory();

            //set the size of the views to fill the entire navigation frame (needs to be done manually (?))
            gridViewTest.Dock = DockStyle.Fill;
            textManipulationView.Dock = DockStyle.Fill;
            tableLayoutPanelTest.Dock = DockStyle.Fill;

            //transition
            navigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.Push;
            navigationFrame1.TransitionAnimationProperties.FrameInterval = 1000;

            //assigns to each page a given view, the current switched via accordion controlls
            navigationPage1.Controls.Add(gridViewTest);
            navigationPage2.Controls.Add(textManipulationView);
            navigationPage3.Controls.Add(tableLayoutPanelTest);

            accordionControlElement1.Text = "Grid View Test";
            accordionControlElement2.Text = "Stuff";
            accordionControlElement3.Text = "Text Manipulation";
            accordionControlElement4.Text = "Table Layout";

            // popup radio setup
            SetupPopupControl();
        }

        private void SetupPopupControl()
        {
            radioGroup1.Properties.Items.AddRange(new[] {
                new RadioGroupItem(1, "en"),
                new RadioGroupItem(2, "fr"),
            });

            // Link the popup control  
            popupContainerEdit1.Properties.PopupControl = popupContainerControl1;
            popupContainerEdit1.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

            // set default value  
            popupContainerEdit1.EditValue = 1; // Default selection  
            radioGroup1.EditValue = popupContainerEdit1.EditValue;
            popupContainerEdit1.Text = radioGroup1.Properties.Items
                .FirstOrDefault(i => i.Value.Equals(radioGroup1.EditValue))?.Description;

            //Handle RadioGroup selection changed event:
            radioGroup1.SelectedIndexChanged += (s, e) =>
            {
                // Update PopupContainerEdit's value and close popup  
                popupContainerEdit1.EditValue = radioGroup1.EditValue;
                popupContainerEdit1.Text = radioGroup1.Properties.Items
                    .FirstOrDefault(i => i.Value.Equals(radioGroup1.EditValue))?.Description;

                //localization
                string culture = popupContainerEdit1.EditValue.ToString();
                switch (culture)
                {
                    case "fr":
                        localisationProvider.SetCulture(CultureCode.French);
                        break;
                    case "en":
                    default:
                        localisationProvider.SetCulture(CultureCode.English);
                        break;
                }

                //needs to be called to refresh the UI text values
                Refresh();

                popupContainerEdit1.ClosePopup();
            };
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            SwitchPage(navigationPage1);
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            SwitchPage(navigationPage2);
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            SwitchPage(navigationPage3);
        }

        private void SwitchPage(NavigationPage navigationPage)
        {
            IOverlaySplashScreenHandle handle = null;

            OverlayWindowOptions options = new OverlayWindowOptions(
                startupDelay: 100,
                backColor: Color.White,
                opacity: 0.5,
                fadeIn: true,
                fadeOut: false,
                imageSize: new Size(64, 64)
                );

            try
            {
                handle = SplashScreenManager.ShowOverlayForm(this, options);

                navigationFrame1.SelectedPage = navigationPage;
            }
            finally
            {
                if (handle != null)
                    SplashScreenManager.CloseOverlayForm(handle);
            }
        }
    }
}