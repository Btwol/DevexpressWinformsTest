using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace XtraFormsTest.Forms
{
    public partial class FlowLayoutCardsTest : DevExpress.XtraEditors.XtraForm
    {
        public FlowLayoutCardsTest()
        {
            InitializeComponent();

            for (int i = 0; i < 30; i++)
            {
                Panel card = new Panel();
                //card.Size = new Size(200, 300); // Adjust size as needed
                card.BorderStyle = BorderStyle.FixedSingle;

                Label label = new Label();
                label.Text = $"Card {i + 1}";
                label.Dock = DockStyle.Top;
                card.Controls.Add(label);

                Button button = new Button();
                button.Text = "Open Form";
                button.Dock = DockStyle.Bottom;
                //button.Click += (sender, e) => OpenNewForm();
                card.Controls.Add(button);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        //private void OpenNewForm()
        //{
        //    GridViewTest newForm = new GridViewTest();
        //    newForm.Text = "New Form";
        //    newForm.Show();
        //}

    }
}