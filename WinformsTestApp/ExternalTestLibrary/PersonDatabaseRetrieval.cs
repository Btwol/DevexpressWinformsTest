using System.ComponentModel.DataAnnotations;
using ExternalTestLibrary.Resources;

namespace ExternalTestLibrary
{
    public class Person
    {
        [Required(ErrorMessageResourceType = typeof(ValidationMessages),
            ErrorMessageResourceName = nameof(ValidationMessages.NameRequired))]
        public string Name { get; set; }
        public int Value { get; set; }
    }

    //database retrieval
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();
    }

    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person { Name = "John Doe", Value = 1 },
                new Person { Name = "Jane Smith", Value = 2 },
                new Person { Name = "Sam Brown", Value = 3 }
            };
        }
    }
}
