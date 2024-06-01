using System.ComponentModel.DataAnnotations;

namespace RentadeCarros.Artefactos
{
    public class Vehiculos
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La marca es obligatoria")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "El modelo es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "El año es obligatorio")]
        [Range(1886, 9999, ErrorMessage = "El año debe estar entre 1886 y 9999")]
        public int? Año { get; set; }

        virtual public ICollection<Reservaciones>? Reservaciones { get; set; }
    }
}

