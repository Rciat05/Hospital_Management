using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Ingreso
{
    public interface IIngresoRepository
    {
        Task AddAsync(IngresoModel ingreso);
        Task DeleteAsync(int id);
        Task EditAsync(IngresoModel ingreso);
        Task<IEnumerable<IngresoModel>> GetAllAsync();
        Task<IngresoModel?> GetByIdAsync(int id);
    }
}