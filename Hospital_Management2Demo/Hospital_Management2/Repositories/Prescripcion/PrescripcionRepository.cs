using Hospital_Management2.Data;
using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Prescripcion
{
    public class PrescripcionRepository : IPrescripcionRepository
    {
        private readonly ISqlDataAccess _dataAccess;

        public PrescripcionRepository(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<PrescripcionModel>> GetAllAsync()
        {
            return await _dataAccess.GetDataAsync<PrescripcionModel, dynamic>(
                "spPrescripcion_GetAll",
                new { }
                );
        }

        public async Task<PrescripcionModel?> GetByIdAsync(int id)
        {
            var prescripcion = await _dataAccess.GetDataAsync<PrescripcionModel, dynamic>(
                "spPrescripcion_GetByID",
                new { PrescripcionID = id }
                );

            return prescripcion.FirstOrDefault();
        }

        public async Task EditAsync(PrescripcionModel prescripcion)
        {
            await _dataAccess.SaveDataAsync(
                "spPrescripcion_Update",
                prescripcion
                );
        }

        public async Task DeleteAsync(int id)
        {
            await _dataAccess.SaveDataAsync(
                "spPrescripcion_Delete",
                new { PrescripcionID = id }
                );
        }

        public async Task AddAsync(PrescripcionModel prescripcion)
        {
            await _dataAccess.SaveDataAsync(
                "spPrescripcion_Insert",
                new { prescripcion.CitaID, prescripcion.MedicamentoID });
        }


    }
}
