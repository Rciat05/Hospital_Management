namespace Hospital_Management2.Models
{
    public class DoctorModel
    {
        public int DoctorID { get; set; }
        public string NombreDoctor { get; set; }
        public string ApellidoDoctor { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Estado { get; set; }
        
    }
}
