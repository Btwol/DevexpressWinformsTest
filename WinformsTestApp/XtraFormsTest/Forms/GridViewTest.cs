using System;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.Utils.MVVM;
using XtraFormsTest.ViewModels;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;
using ExternalTestLibrary;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using DevExpress.Dialogs.Core.View;
using DevExpress.XtraEditors.Controls;
using System.Globalization;
using System.Threading;
using DevExpress.XtraVerticalGrid;

namespace XtraFormsTest.Forms
{
    public partial class GridViewTest : DevExpress.XtraEditors.XtraForm
    {
        private readonly MVVMContext mvvmContext;
        private readonly BindingList<Person> people;

        public GridViewTest(PersonViewModel viewModel)
        {
            InitializeComponent();

            // Initialize MVVM Context  
            mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = this;
            mvvmContext.SetViewModel(typeof(PersonViewModel), viewModel);
            var fluent = mvvmContext.OfType<PersonViewModel>();

            //change localisation to french, note: "data annotations and validation messages might not reflect
            //the intended culture correctly if you set culture too late.
            //Ideally, set culture before creating ViewModels or UI bindings."
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr");

            // Set up the binding for the grid control
            fluent.ViewModel.LoadPeople();

            

            //databinding
            gridControl1.DataSource = people;
            //can be manually set here on in the nameColumn properties in the designer
            nameColumn.FieldName = nameof(Person.Name);
            valuedColumn.FieldName = nameof(Person.Value);

            //localisation - assign proper column name at initialization
            nameColumn.Caption = "Name"; //currently hardcoded to english, but take from existing resources
            valuedColumn.Caption = "Value";
        }

        private void gridView1_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            MessageBox.Show(this, e.ErrorText, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var fluent = mvvmContext.OfType<PersonViewModel>();
            fluent.ViewModel.SaveChanges();
        }
    }
}