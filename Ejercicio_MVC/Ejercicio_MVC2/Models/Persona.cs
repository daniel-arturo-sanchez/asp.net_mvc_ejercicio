using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_MVC2.Models
{
    public class Persona
    {
        public Persona(int Id, string Name, int Edad, string? Email)
        {
            this.Id = Id;
            this.Name = Name;
            this.Edad = Edad;
            this.Email = Email;
        }
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Edad")]
        public int Edad { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
