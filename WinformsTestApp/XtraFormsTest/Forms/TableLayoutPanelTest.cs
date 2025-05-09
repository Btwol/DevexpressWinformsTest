using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;

namespace XtraFormsTest.Forms
{
    public partial class TableLayoutPanelTest : DevExpress.XtraEditors.XtraForm
    {
        private readonly Func<GridViewTest> gridViewTestFormFactory;
        private readonly Func<TextManipulationView> textManipulationViewFormFactory;

        public TableLayoutPanelTest(Func<GridViewTest> formFactory,
            Func<TextManipulationView> textManipulationViewFormFactory)
        {
            InitializeComponent();

            this.gridViewTestFormFactory = formFactory;
            this.textManipulationViewFormFactory = textManipulationViewFormFactory;

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    //Panel card = CreateCard((s, e) => OpenNewForm(formFactory), "Card");

                    //tablePanel1.Controls.Add(card);
                    //tablePanel1.SetCell(card, i, j);
                }
            }

            //Panel card = CreateCard((s, e) => OpenNewForm(textManipulationViewFormFactory), "Card");
            //tablePanel1.Controls.Add(card);
            //tablePanel1.SetCell(card, 1, 1);
        }

        private Panel CreateCard(EventHandler buttonClickAction, string cardName)
        {
            Panel card = new Panel();
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Dock = DockStyle.Fill;
            card.BackColor = Color.LightBlue;
            card.Padding = new Padding(10);
            card.Margin = new Padding(25);

            Label label = new Label();
            label.Text = cardName;
            label.Dock = DockStyle.Fill;
            label.Font = new Font("Arial", 16, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;
            card.Controls.Add(label);

            Button button = new Button();
            button.Text = "Open Form";
            button.Dock = DockStyle.Bottom;
            button.Click += buttonClickAction;
            button.BackColor = Color.LightGreen;
            card.Controls.Add(button);
            return card;
        }

        //opens a new window without closing the old one
        private void OpenNewForm(Func<XtraForm> formFactory)
        {
            //creating new form by calling the static ServiceProvider
            //var newForm = Program.ServiceProvider.GetRequiredService<GridViewTest>();

            //using a constructor injected Func<GridViewTest> formFactory, defined in program.cs as 
            //"services.AddTransient<Func<GridViewTest>>(provider => () => provider.GetRequiredService<GridViewTest>());  "
            var newForm = formFactory();
            newForm.Text = "New Form";
            newForm.Show();

            //closes the current window
            //this.Close();
        }
    }
}