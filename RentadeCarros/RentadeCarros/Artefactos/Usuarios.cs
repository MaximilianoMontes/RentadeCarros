using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace RentadeCarros.Artefactos
{
    public class Usuarios
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El Número telefónico es obligatorio")]
        [Phone(ErrorMessage = "Debe ser un teléfono válido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? NumTelefonico { get; set; }

        virtual public ICollection<Reservaciones>? Reservaciones { get; set;}
    }
}
