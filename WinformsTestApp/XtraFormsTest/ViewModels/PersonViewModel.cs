using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using ExternalTestLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace XtraFormsTest.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {
        private IPersonRepository personRepository;

        public BindingList<Person> People { get; private set; }

        public PersonViewModel(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
            LoadPeople();
        }

        private void LoadPeople()
        {
            // Simulate loading data from a database
            var people = personRepository.GetPeople();

            // Create the new BindingList
            People = new BindingList<Person>(people.ToList())
            {
                // Allow new parts to be added, but not removed once committed.        
                AllowNew = true,
                AllowRemove = true,

                // Raise ListChanged events when new parts are added.
                RaiseListChangedEvents = true,

                // Allow parts to be edited.
                AllowEdit = true
            };

            RaisePropertyChanged(nameof(People));
        }

        public void SaveChanges()
        {
            //simulates saving changes to a database
            //repository.SaveChanges();

            RaisePropertyChanged(nameof(People));
        }
    }
}
