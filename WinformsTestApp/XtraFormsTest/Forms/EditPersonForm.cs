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
using DevExpress.Dialogs.Core.View;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using ExternalTestLibrary;
using XtraFormsTest.Services;
using XtraFormsTest.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace XtraFormsTest.Forms
{
    public partial class EditPersonForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly MVVMContext mvvmContext;
        private readonly MVVMContextFluentAPI<EditPersonViewModel> fluent;

        public EditPersonForm(IUIConfigService uIConfigService, EditPersonViewModel viewModel)
        {
            InitializeComponent();

            //configure the form
            uIConfigService.ApplyLabelDefaults(nameLabel);

            mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = this;
            mvvmContext.SetViewModel(typeof(EditPersonViewModel), viewModel);
            fluent = mvvmContext.OfType<EditPersonViewModel>();

            fluent.SetBinding(nameEdit, x => x.Text, m => m.EditedPerson.Name);
            fluent.SetBinding(valueEdit, x => x.Value, m => m.EditedPerson.Value);
        }

        public Person GetEditedPerson()
        {
            return fluent.ViewModel.EditedPerson;
        }

        public void SetEditedPerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }
            fluent.ViewModel.EditedPerson = person;
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
            var fluent = mvvmContext.OfType<EditPersonViewModel>();
            fluent.ViewModel.ValidatePerson(sender, e);
        }
    }
}