using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Habitacion
{
    public interface IHabitacionRepository
    {
        Task AddAsync(HabitacionModel habitacion);
        Task DeleteAsync(int id);
        Task EditAsync(HabitacionModel habitacion);
        Task<IEnumerable<HabitacionModel>> GetAllAsync();
        Task<HabitacionModel?> GetByIdAsync(int id);
    }
}