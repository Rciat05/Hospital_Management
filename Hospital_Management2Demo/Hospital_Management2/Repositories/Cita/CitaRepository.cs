using Hospital_Management2.Data;
using Hospital_Management2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management2.Repositories.Cita
{
    public class CitaRepository : ICitaRepository
    {
        private readonly ISqlDataAccess _dataAccess;

        public CitaRepository(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<CitaModel>> GetAllAsync()
        {
            var citas = await _dataAccess.GetDataAsync<CitaModel, dynamic>(
                "spCita_GetAll",
                new { }
            );

            return citas;
        }

        public async Task<CitaModel?> GetByIdAsync(int id)
        {
            var citas = await _dataAccess.GetDataAsync<CitaModel, dynamic>(
                "spCita_GetByID",
                new { CitaID = id }
            );

            return citas.FirstOrDefault();
        }

        public async Task EditAsync(CitaModel cita)
        {
            await _dataAccess.SaveDataAsync(
                "spCita_Update",
                cita
            );
        }

        public async Task DeleteAsync(int id)
        {
            await _dataAccess.SaveDataAsync(
                "spCita_Delete",
                new { CitaID = id }
            );
        }

        public async Task AddAsync(CitaModel cita)
        {
            await _dataAccess.SaveDataAsync(
                "spCita_Insert",
                new
                {
                    cita.FechaCita,
                    cita.MotivoCita,
                    cita.EstadoCitas,
                    cita.NombrePaciente,
                    cita.ApellidoPaciente,
                    cita.NombreDoctor,
                    cita.ApellidoDoctor
                }
            );
        }
    }
}
