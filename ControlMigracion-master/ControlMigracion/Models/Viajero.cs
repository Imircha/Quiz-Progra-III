using System;
using System.ComponentModel.DataAnnotations;

namespace ControlMigracion.Models
{
    public class Viajero
    {
        public int ViajeroID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El número de pasaporte es requerido")]
        [StringLength(20, ErrorMessage = "El número de pasaporte no puede tener más de 20 caracteres")]
        public string Pasaporte { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "La nacionalidad es requerida")]
        [StringLength(50, ErrorMessage = "La nacionalidad no puede tener más de 50 caracteres")]
        public string Nacionalidad { get; set; }
    }
}

