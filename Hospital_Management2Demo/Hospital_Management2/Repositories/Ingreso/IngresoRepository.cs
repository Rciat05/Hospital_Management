using Hospital_Management2.Data;
using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Ingreso
{
    public class IngresoRepository : IIngresoRepository
    {
        private readonly ISqlDataAccess _dataAccess;

        public IngresoRepository(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<IngresoModel>> GetAllAsync()
        {
            return await _dataAccess.GetDataAsync<IngresoModel, dynamic>(
                "spIngreso_GetAll",
                new { }
                );
        }

        public async Task<IngresoModel?> GetByIdAsync(int id)
        {
            var ingresos = await _dataAccess.GetDataAsync<IngresoModel, dynamic>(
                "spIngreso_GetByID",
                new { IngresoID = id }
                );

            return ingresos.FirstOrDefault();
        }

        public async Task EditAsync(IngresoModel ingreso)
        {
            await _dataAccess.SaveDataAsync(
                "spIngreso_Update",
                ingreso
                );
        }

        public async Task DeleteAsync(int id)
        {
            await _dataAccess.SaveDataAsync(
                "spIngreso_Delete",
                new { IngresoID = id }
                );
        }

        public async Task AddAsync(IngresoModel ingreso)
        {
            await _dataAccess.SaveDataAsync(
                "spIngreso_Insert",
                new { ingreso.PacienteID, ingreso.HabitacionID, ingreso.FechaIngreso, ingreso.FechaAlta, ingreso.DiagnosticoInicial, ingreso.EstadoIngresos });
        }
    }
}
