using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_MVC2.Models
{
    public class Person
    {
        public Person(int id, string name, int age, string? email)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Edad")]
        public int Age { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
