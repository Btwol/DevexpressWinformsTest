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
using XtraFormsTest.Resources;
using System.Drawing;

namespace XtraFormsTest.Forms
{
    public partial class GridViewTest : DevExpress.XtraEditors.XtraForm
    {
        private readonly MVVMContext mvvmContext;

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
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");

            //databinding
            gridControl1.DataSource = fluent.ViewModel.People;
            //can be manually set here on in the nameColumn properties in the designer
            nameColumn.FieldName = nameof(Person.Name);
            valuedColumn.FieldName = nameof(Person.Value);

            //localisation - assign proper column name at initialization
            nameColumn.Caption = ColumnNames.Name;
            valuedColumn.Caption = ColumnNames.Value;

            //cell text allignment
            nameColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            valuedColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;

            //allow adding and deleting new rows 
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;

            //set the new row to be at the top of the grid
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;

            //set event for when new row is added (which can also be done in designer)
            //gridView1.InitNewRow += GridView1_InitNewRow;

            //sets the people count at the page bottom
            fluent.SetBinding(labelControl1, x => x.Text, m => m.People.Count);

            //enables the embedded navigator
            //gridControl1.UseEmbeddedNavigator = true;
            //gridControl1.EmbeddedNavigator.Appearance.Font = new Font("Segoe UI", 20, FontStyle.Regular); // Increase font size  
            //gridControl1.EmbeddedNavigator.Padding = new Padding(5);
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

        private void gridView1_InitNewRow_1(object sender, InitNewRowEventArgs e)
        {
            var gridView = sender as GridView;
            if (gridView != null)
            {
                var newPerson = new Person { Name = "", Value = 0 };
                gridView.SetRowCellValue(e.RowHandle, nameColumn, newPerson.Name);
                gridView.SetRowCellValue(e.RowHandle, valuedColumn, newPerson.Value);

                var fluent = mvvmContext.OfType<PersonViewModel>();
                fluent.ViewModel.SaveChanges();
            }
        }

        private void rowDeleteButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = gridView1.GetFocusedRow() as Person;

            if (selectedPerson != null)
            {
                // Remove the selected person from the BindingList
                var fluent = mvvmContext.OfType<PersonViewModel>();
                fluent.ViewModel.People.Remove(selectedPerson);
                // Save changes to the repository
                fluent.ViewModel.SaveChanges();
            }
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                // Get the clicked row handle  
                int rowHandle = e.HitInfo.RowHandle;

                // Retrieve your data object  
                var person = view.GetRow(rowHandle) as Person;

                if (person != null)
                {
                    // Create a context menu  
                    DevExpress.Utils.Menu.DXMenuItem menuItemEdit = new DevExpress.Utils.Menu.DXMenuItem("Edit", (s, ea) =>
                    {
                        MessageBox.Show($"Editing {person.Name}");
                    });

                    DevExpress.Utils.Menu.DXMenuItem menuItemDelete = new DevExpress.Utils.Menu.DXMenuItem("Delete", (s, ea) =>
                    {
                        var result = MessageBox.Show("Are you sure you want to delete the selected item?",
                             "Confirm Deletion",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            // User confirmed deletion  
                            var fluent = mvvmContext.OfType<PersonViewModel>();
                            fluent.ViewModel.People.Remove(person);
                            // Save changes to the repository
                            fluent.ViewModel.SaveChanges();
                        }
                    });

                    // Clear default items and add your custom items  
                    e.Menu.Items.Clear();
                    e.Menu.Items.Add(menuItemEdit);
                    e.Menu.Items.Add(menuItemDelete);
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            var person = view.GetFocusedRow() as Person;

            if (person != null)
            {
                var editForm = new EditPersonForm(new Person
                {
                    Name = person.Name,
                    Value = person.Value
                });

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the existing object with edited values  
                    person.Name = editForm.EditedPerson.Name;
                    person.Value = editForm.EditedPerson.Value;

                    //save db changes
                    var fluent = mvvmContext.OfType<PersonViewModel>();
                    fluent.ViewModel.SaveChanges();

                    // Refresh the view to reflect changes  
                    view.RefreshData();
                }
                
                //using (var editForm = new EditPersonForm(new Person
                //{
                //    Name = person.Name,
                //    Value = person.Value
                //}))
                //{
                //    if (editForm.ShowDialog() == DialogResult.OK)
                //    {
                //        // Update the existing object with edited values  
                //        person.Name = editForm.EditedPerson.Name;
                //        person.Value = editForm.EditedPerson.Value;

                //        //save db changes
                //        var fluent = mvvmContext.OfType<PersonViewModel>();
                //        fluent.ViewModel.SaveChanges();

                //        // Refresh the view to reflect changes  
                //        view.RefreshData();
                //    }
                //}
            }
        }

        private void rowCreateButton_Click(object sender, EventArgs e)
        {
            gridView1.ClearSelection();

            using (var editForm = new EditPersonForm(null))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    //add new person to list
                    var fluent = mvvmContext.OfType<PersonViewModel>();
                    fluent.ViewModel.People.Add(editForm.EditedPerson);

                    //save db changes
                    fluent.ViewModel.SaveChanges();

                    // Refresh the view to reflect changes  
                    gridView1.RefreshData();
                }
            }
        }
    }
}