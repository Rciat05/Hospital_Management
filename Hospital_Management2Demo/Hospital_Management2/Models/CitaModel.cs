using System;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management2.Models
{
    public class CitaModel
    {
        [Key]
        public int CitaID { get; set; }

        [Required(ErrorMessage = "El nombre del paciente es requerido")]
        public string NombrePaciente { get; set; }

        [Required(ErrorMessage = "El apellido del paciente es requerido")]
        public string ApellidoPaciente { get; set; }

        [Required(ErrorMessage = "El nombre del doctor es requerido")]
        public string NombreDoctor { get; set; }

        [Required(ErrorMessage = "El apellido del doctor es requerido")]
        public string ApellidoDoctor { get; set; }

        [Required(ErrorMessage = "La fecha de la cita no debe estar vacío")]
        public DateTime FechaCita { get; set; }

        [Required(ErrorMessage = "El motivo de la cita es requerido")]
        [StringLength(200, ErrorMessage = "El motivo de la cita no puede exceder los 200 caracteres")]
        public string MotivoCita { get; set; }

        [Required(ErrorMessage = "El estado de la cita es requerido")]
        [StringLength(1, ErrorMessage = "El estado de la cita debe ser de un solo carácter")]
        public string EstadoCitas { get; set; }
    }
}
