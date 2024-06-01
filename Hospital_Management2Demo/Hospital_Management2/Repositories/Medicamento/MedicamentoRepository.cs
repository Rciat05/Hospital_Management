using Hospital_Management2.Data;
using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Medicamento
{
    public class MedicamentoRepository : IMedicamentoRepository
    {
        private readonly ISqlDataAccess _dataAccess;

        public MedicamentoRepository(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<MedicamentoModel>> GetAllAsync()
        {
            return await _dataAccess.GetDataAsync<MedicamentoModel, dynamic>(
                "spMedicamento_GetAll",
                new { }
                );
        }

        public async Task<MedicamentoModel?> GetByIdAsync(int id)
        {
            var medicamentos = await _dataAccess.GetDataAsync<MedicamentoModel, dynamic>(
                "spMedicamento_GetByID",
                new { MedicamentoID = id }
                );

            return medicamentos.FirstOrDefault();
        }

        public async Task EditAsync(MedicamentoModel medicamento)
        {
            await _dataAccess.SaveDataAsync(
                "spMedicamento_Update",
                medicamento
                );
        }

        public async Task DeleteAsync(int id)
        {
            await _dataAccess.SaveDataAsync(
                "spMedicamento_Delete",
                new { MedicamentoID = id }
                );
        }

        public async Task AddAsync(MedicamentoModel medicamento)
        {
            await _dataAccess.SaveDataAsync(
                "spMedicamento_Insert",
                new { medicamento.Nombre, medicamento.Descripcion, medicamento.TiempoAdministrable, medicamento.Cantidad });
        }
    }
}
