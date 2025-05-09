using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm;
using ExternalTestLibrary;

namespace XtraFormsTest.ViewModels
{
    public class EditPersonViewModel : ViewModelBase
    {
        private Person editedPerson = new();
        public Person EditedPerson { 
            get => editedPerson;
            set
            {
                editedPerson = value;
                RaisePropertyChanged(nameof(EditedPerson));
            }
        }

        public void ValidatePerson(object sender, CancelEventArgs e)
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
