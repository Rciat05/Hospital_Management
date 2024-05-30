using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Paciente
{
    public interface IPacienteRepository
    {
        Task AddAsync(PacienteModel paciente);
        Task DeleteAsync(int id);
        Task EditAsync(PacienteModel paciente);
        Task<IEnumerable<PacienteModel>> GetAllAsync();
        Task<PacienteModel?> GetByIdAsync(int id);
    }
}