using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using XtraFormsTest.ViewModels;

namespace XtraFormsTest
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        MVVMContext mvvmContext;

        public XtraForm1()
        {
            InitializeComponent();

            //// Initialize MVVM Context  
            //mvvmContext = new MVVMContext();
            //mvvmContext.ContainerControl = this;

            //// Set ViewModel instance  
            //mvvmContext.ViewModelType = typeof(PersonViewModel);

            //// Data-bindings  
            //var fluent = mvvmContext.OfType<PersonViewModel>();

            ////Displays window with hardcoded msg in ViewModel
            ////simpleButton1.BindCommand(fluent.ViewModel.SayHelloCommand);
            //fluent.BindCommand(simpleButton1, x => x.SayHello);


            ////Displays window with msg passed from View to ViewModel
            //object parameter = "Text from view";
            //fluent.BindCommand(simpleButton2, x => x.SayText, x => parameter);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}