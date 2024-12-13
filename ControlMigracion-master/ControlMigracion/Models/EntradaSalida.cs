using System;
using System.ComponentModel.DataAnnotations;

namespace ControlMigracion.Models
{
    public class EntradaSalida
    {
        public int EntradaSalidaID { get; set; }

        [Required(ErrorMessage = "El ID del viaje es requerido")]
        public int ViajeID { get; set; }

        [Required(ErrorMessage = "El ID del país es requerido")]
        public int PaisID { get; set; }

        [Required(ErrorMessage = "La fecha es requerida")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El tipo de movimiento es requerido")]
        [StringLength(10)]
        public string Tipo { get; set; }

        public virtual Viaje Viaje { get; set; }
        public virtual Pais Pais { get; set; }
    }
}

