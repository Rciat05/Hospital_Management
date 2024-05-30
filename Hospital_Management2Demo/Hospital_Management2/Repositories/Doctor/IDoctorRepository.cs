using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Doctor
{
    public interface IDoctorRepository
    {
        Task AddAsync(DoctorModel doctor);
        Task DeleteAsync(int id);
        Task EditAsync(DoctorModel doctor);
        Task<IEnumerable<DoctorModel>> GetAllAsync();
        Task<DoctorModel?> GetByIdAsync(int id);
    }
}