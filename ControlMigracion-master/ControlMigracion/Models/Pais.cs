using System.ComponentModel.DataAnnotations;

namespace ControlMigracion.Models
{
    public class Pais
    {
        public int PaisID { get; set; }

        [Required(ErrorMessage = "El nombre del país es requerido")]
        [StringLength(100, ErrorMessage = "El nombre del país no puede tener más de 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El código ISO es requerido")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "El código ISO debe tener exactamente 3 caracteres")]
        public string CodigoISO { get; set; }
    }
}

