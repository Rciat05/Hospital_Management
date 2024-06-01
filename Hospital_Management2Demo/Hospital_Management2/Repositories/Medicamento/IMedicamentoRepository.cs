using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Medicamento
{
    public interface IMedicamentoRepository
    {
        Task AddAsync(MedicamentoModel medicamento);
        Task DeleteAsync(int id);
        Task EditAsync(MedicamentoModel medicamento);
        Task<IEnumerable<MedicamentoModel>> GetAllAsync();
        Task<MedicamentoModel?> GetByIdAsync(int id);
    }
}