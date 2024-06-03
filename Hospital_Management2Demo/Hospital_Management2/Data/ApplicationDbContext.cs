using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Hospital_Management2.Models;

namespace Hospital_Management2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Hospital_Management2.Models.PacienteModel> PacienteModel { get; set; } = default!;
        public DbSet<Hospital_Management2.Models.HabitacionModel> HabitacionModel { get; set; } = default!;
        public DbSet<Hospital_Management2.Models.DoctorModel> DoctorModel { get; set; } = default!;
        public DbSet<Hospital_Management2.Models.MedicamentoModel> MedicamentoModel { get; set; } = default!;
        public DbSet<Hospital_Management2.Models.CitaModel> CitaModel { get; set; } = default!;
        public DbSet<Hospital_Management2.Models.PrescripcionModel> PrescripcionModel { get; set; } = default!;
    }
}
