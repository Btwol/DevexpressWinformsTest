using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using XtraFormsTest.ViewModels;

namespace XtraFormsTest.Forms
{
    public partial class NavigationFrameTest : DevExpress.XtraEditors.XtraForm
    {
        private readonly GridViewTest gridViewTest;
        private readonly TextManipulationView textManipulationView;

        public NavigationFrameTest(Func<GridViewTest> gridViewTestFactory, 
            Func<TextManipulationView> textManipulationViewFactory)
        { 
            InitializeComponent();
            gridViewTest = gridViewTestFactory();
            textManipulationView = textManipulationViewFactory();

            //set the size of the views to fill the entire navigation frame
            gridViewTest.Dock = DockStyle.Fill;
            textManipulationView.Dock = DockStyle.Fill;

            //transition
            navigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.Push;
            navigationFrame1.TransitionAnimationProperties.FrameInterval = 1000;

            //assigns to each page a given view, the current switched via accordion controlls
            navigationPage1.Controls.Add(gridViewTest);
            navigationPage2.Controls.Add(textManipulationView);
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            SwitchPage(navigationPage1);
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            SwitchPage(navigationPage2);
        }

        private void SwitchPage(NavigationPage navigationPage)
        {
            IOverlaySplashScreenHandle handle = null;

            OverlayWindowOptions options = new OverlayWindowOptions(
                startupDelay: 0,
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

                Application.DoEvents();
            }
            finally
            {
                if (handle != null)
                    SplashScreenManager.CloseOverlayForm(handle);
            }
        }
    }
}