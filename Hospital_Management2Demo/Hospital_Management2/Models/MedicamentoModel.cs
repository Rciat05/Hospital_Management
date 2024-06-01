using System.ComponentModel.DataAnnotations;

namespace Hospital_Management2.Models
{
    public class MedicamentoModel
    {
        [Key]
        public int MedicamentoID { set; get; } 

        [Required(ErrorMessage = "El nombre del medicamento no debe estar vacío")]
        public string Nombre { set; get; }

        [Required(ErrorMessage = "La descripcion del medicamento no debe estar vacío")]
        public string Descripcion { set; get; }

        [Required(ErrorMessage = "El tiempo administrable del medicamento no debe estar vacío")]
        public string TiempoAdministrable { set; get; }

        [Required(ErrorMessage = "La cantidad del medicamento no debe estar vacío")]
        public string Cantidad { set; get; }
    }
}
