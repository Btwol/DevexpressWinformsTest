using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Dialogs.Core.View;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using XtraFormsTest.ViewModels;

namespace XtraFormsTest.Forms
{
    public partial class TextManipulationView : DevExpress.XtraEditors.XtraForm
    {
        MVVMContext mvvmContext;

        public TextManipulationView(TextManipulationViewModel viewModel)
        {
            InitializeComponent();

            mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = this;
            mvvmContext.SetViewModel(typeof(TextManipulationViewModel), viewModel);
            var fluent = mvvmContext.OfType<TextManipulationViewModel>();

            fluent.SetBinding(labelControl1, x => x.Text, m => m.LabelText);
            fluent.SetBinding(textEdit1, x => x.Text, m => m.EditedText);
            fluent.SetBinding(spinEdit1, x => x.Value, m => m.NumValue);
            fluent.BindCommand(simpleButton1, vm => vm.ResetValues);
        }
    }
}