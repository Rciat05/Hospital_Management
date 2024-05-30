namespace Hospital_Management2.Models
{
    public class PacienteModel
    {
        public int pacienteID { get; set; }
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo {  get; set; }
        public string Telefono {  get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
