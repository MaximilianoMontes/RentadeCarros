using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentadeCarros.Artefactos
{
    public class Reservaciones : IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        public DateOnly? Fechainicioreserva { get; set; }

        [Required(ErrorMessage = "La fecha de final es obligatoria")]
        public DateOnly? Fechafinalreserva { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Fechainicioreserva.HasValue && Fechafinalreserva.HasValue)
            {
                if (Fechainicioreserva.Value > Fechafinalreserva.Value)
                {
                    yield return new ValidationResult(
                        "La fecha de inicio debe ser anterior o igual a la fecha de final.",
                        new[] { nameof(Fechainicioreserva), nameof(Fechafinalreserva) });
                }
            }
        }
        public int? UsuariosId { get; set; }
        virtual public Usuarios? Usuarios { get; set; }
        public int? VehiculosId { get; set; }
        virtual public Vehiculos? Vehiculos { get; set; }
    }
}
