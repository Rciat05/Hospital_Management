using Hospital_Management2.Data;
using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Habitacion
{
    public class HabitacionRepository : IHabitacionRepository
    {
        private readonly ISqlDataAccess _dataAccess;

        public HabitacionRepository(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<HabitacionModel>> GetAllAsync()
        {
            return await _dataAccess.GetDataAsync<HabitacionModel, dynamic>(
                "spHabitacion_GetAll",
                new { }
                );
        }

        public async Task<HabitacionModel?> GetByIdAsync(int id)
        {
            var habitaciones = await _dataAccess.GetDataAsync<HabitacionModel, dynamic>(
                "spHabitacion_GetByID",
                new { HabitacionID = id }
                );

            return habitaciones.FirstOrDefault();
        }

        public async Task EditAsync(HabitacionModel habitacion)
        {
            await _dataAccess.SaveDataAsync(
                "spHabitacion_Update",
                habitacion
                );
        }

        public async Task DeleteAsync(int id)
        {
            await _dataAccess.SaveDataAsync(
                "spHabitacion_Delete",
                new { HabitacionID = id }
                );
        }

        public async Task AddAsync(HabitacionModel habitacion)
        {
            await _dataAccess.SaveDataAsync(
                "spHabitacion_Insert",
                new { habitacion.NumeroHabitacion, habitacion.TipoHabitacion, habitacion.EstadoHabitaciones });
        }
    }

}

