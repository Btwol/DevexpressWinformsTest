using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using ExternalTestLibrary;
using XtraFormsTest.Resources;
using XtraFormsTest.Services;
using XtraFormsTest.ViewModels;

namespace XtraFormsTest.Forms
{
    public partial class GridViewTest : XtraUserControl //DevExpress.XtraEditors.XtraForm
    {
        private readonly MVVMContext mvvmContext;
        private readonly MVVMContextFluentAPI<PersonViewModel> fluent;
        private readonly Func<EditPersonForm> editPersonFormFactory;
        private readonly ILocalisationProvider _localisationProvider;

        public GridViewTest(PersonViewModel viewModel, Func<EditPersonForm> editPersonFormFactory, 
            ILocalisationProvider localisationProvider)
        {
            InitializeComponent();

            _localisationProvider = localisationProvider;

            // Initialize MVVM Context  
            mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = this;
            mvvmContext.SetViewModel(typeof(PersonViewModel), viewModel);
            fluent = mvvmContext.OfType<PersonViewModel>();

            //change localisation to french, note: "data annotations and validation messages might not reflect
            //the intended culture correctly if you set culture too late.
            //Ideally, set culture before creating ViewModels or UI bindings."
            //Thread.CurrentThread.CurrentUICulture = _localisationProvider.CultureInfo;
            //Thread.CurrentThread.CurrentCulture = _localisationProvider.CultureInfo;

            //databinding
            gridControl1.DataSource = fluent.ViewModel.People;
            //can be manually set here on in the nameColumn properties in the designer
            nameColumn.FieldName = nameof(Person.Name);
            valuedColumn.FieldName = nameof(Person.Value);

            //allow/disable direct cell value editing
            //nameColumn.OptionsColumn.AllowEdit = false;
            //valuedColumn.OptionsColumn.AllowEdit = false;

            //localisation - assign proper column name at initialization
            ApplyLocalizedNames();

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
            this.editPersonFormFactory = editPersonFormFactory;

            //enables the embedded navigator
            //gridControl1.UseEmbeddedNavigator = true;
            //gridControl1.EmbeddedNavigator.Appearance.Font = new Font("Segoe UI", 20, FontStyle.Regular); // Increase font size  
            //gridControl1.EmbeddedNavigator.Padding = new Padding(5);
        }

        private void ApplyLocalizedNames()
        {
            nameColumn.Caption = ColumnNames.Name;
            valuedColumn.Caption = ColumnNames.Value;
        }

        //needs (?) to be called when localization/Thread culture value is changed in parent navigation frame
        //on method call Refresh() to apply new localized text values
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ApplyLocalizedNames();
        }

        private void gridView1_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            //MessageBox.Show(this, e.ErrorText, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            fluent.ViewModel.SaveChanges();
        }

        private void rowDeleteButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = gridView1.GetFocusedRow() as Person;

            if (selectedPerson != null)
            {
                // Confirm deletion  
                var result = XtraMessageBox.Show($"Do you really want to delete '{selectedPerson.Name}'?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    fluent.ViewModel.DeletePerson(selectedPerson);
                }
            }
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.MenuType == GridMenuType.Row)
            {
                // Get the clicked row handle  
                int rowHandle = e.HitInfo.RowHandle;

                // Retrieve data object  
                var person = view.GetRow(rowHandle) as Person;

                if (person != null)
                {
                    // Create a context menu  
                    DXMenuItem menuItemEdit = new DXMenuItem("Edit", (s, ea) =>
                    {
                        MessageBox.Show($"Editing {person.Name}");
                    });

                    DXMenuItem menuItemDelete = new DXMenuItem("Delete", (s, ea) =>
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

                    // Clear default items and add custom items  
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
                var editForm = editPersonFormFactory();
                editForm.SetEditedPerson(person);
                //    new EditPersonForm(new Person
                //{
                //    Name = person.Name,
                //    Value = person.Value
                //});

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the existing object with edited values  
                    var editedPerson = editForm.GetEditedPerson();
                    person.Name = editedPerson.Name;
                    person.Value = editedPerson.Value;

                    //save db changes
                    var fluent = mvvmContext.OfType<PersonViewModel>();
                    fluent.ViewModel.SaveChanges();

                    // Refresh the view to reflect changes  
                    view.RefreshData();
                }
            }
        }

        private void rowCreateButton_Click(object sender, EventArgs e)
        {
            gridView1.ClearSelection();

            var editForm = editPersonFormFactory();
            editForm.SetEditedPerson(new Person());

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                //add new person to list
                var newPerson = editForm.GetEditedPerson();
                fluent.ViewModel.People.Add(newPerson);

                //save db changes
                fluent.ViewModel.SaveChanges();

                // Refresh the view to reflect changes  
                gridView1.RefreshData();
            }
        }
    }
}