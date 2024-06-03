using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Cita
{
    public interface ICitaRepository
    {
        Task AddAsync(CitaModel cita);
        Task DeleteAsync(int id);
        Task EditAsync(CitaModel cita);
        Task<IEnumerable<CitaModel>> GetAllAsync();
        Task<CitaModel?> GetByIdAsync(int id);
    }
}