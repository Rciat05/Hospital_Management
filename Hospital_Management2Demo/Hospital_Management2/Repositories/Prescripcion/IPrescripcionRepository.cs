using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Prescripcion
{
    public interface IPrescripcionRepository
    {
        Task AddAsync(PrescripcionModel prescripcion);
        Task DeleteAsync(int id);
        Task EditAsync(PrescripcionModel prescripcion);
        Task<IEnumerable<PrescripcionModel>> GetAllAsync();
        Task<PrescripcionModel?> GetByIdAsync(int id);
    }
}