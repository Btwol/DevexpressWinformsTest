using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using ExternalTestLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace XtraFormsTest.Forms
{
    public partial class EditPersonForm : DevExpress.XtraEditors.XtraForm
    {
        public Person EditedPerson { get; set; }

        public EditPersonForm(Person person = null)
        {
            InitializeComponent();

            if (person == null)
            {
                // Creating new person  
                EditedPerson = new Person();
            }
            else
            {
                // Editing existing person  
                EditedPerson = person;
                nameEdit.Text = EditedPerson.Name;
                valueEdit.Value = EditedPerson.Value;
            }

            nameEdit.DataBindings.Add("Text", EditedPerson, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            valueEdit.DataBindings.Add("Value", EditedPerson, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void nameEdit_Validating(object sender, CancelEventArgs e)
        {

            var context = new ValidationContext(EditedPerson) { MemberName = "Name" };
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateProperty(EditedPerson.Name, context, results);

            if (!isValid)
            {
                e.Cancel = true;
                string errorMessage = results.First().ErrorMessage;
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}