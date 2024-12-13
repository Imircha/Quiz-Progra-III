using System;
using System.ComponentModel.DataAnnotations;

namespace ControlMigracion.Models
{
    public class Viaje
    {
        public int ViajeID { get; set; }

        [Required(ErrorMessage = "El ID del viajero es requerido")]
        public int ViajeroID { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFin { get; set; }

        public virtual Viajero Viajero { get; set; }
    }
}

