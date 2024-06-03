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
            int? pacienteId = await GetPacienteIdAsync(cita.NombrePaciente, cita.ApellidoPaciente);
            if (pacienteId == null)
            {
                throw new Exception("Paciente no encontrado");
            }

            int? doctorId = await GetDoctorIdAsync(cita.NombreDoctor, cita.ApellidoDoctor);
            if (doctorId == null)
            {
                throw new Exception("Doctor no encontrado");
            }

            await _dataAccess.SaveDataAsync(
                "spCita_Insert",
                new
                {
                    PacienteID = pacienteId,
                    DoctorID = doctorId,
                    cita.FechaCita,
                    cita.MotivoCita,
                    cita.EstadoCitas
                }
            );
        }

        private async Task<int?> GetPacienteIdAsync(string nombre, string apellido)
        {
            var paciente = await _dataAccess.GetDataAsync<int, dynamic>(
                "spGetPacienteByName",
                new { NombrePaciente = nombre, ApellidoPaciente = apellido }
            );

            return paciente.FirstOrDefault();
        }

        private async Task<int?> GetDoctorIdAsync(string nombre, string apellido)
        {
            var doctor = await _dataAccess.GetDataAsync<int, dynamic>(
                "spGetDoctorByName",
                new { NombreDoctor = nombre, ApellidoDoctor = apellido }
            );

            return doctor.FirstOrDefault();
        }
    }
}
