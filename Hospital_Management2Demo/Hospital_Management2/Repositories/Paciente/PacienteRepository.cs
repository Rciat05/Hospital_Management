using Hospital_Management2.Data;
using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Paciente
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly ISqlDataAccess _dataAccess;

        public PacienteRepository(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<PacienteModel>> GetAllAsync()
        {
            return await _dataAccess.GetDataAsync<PacienteModel, dynamic>(
                "spPaciente_GetAll",
                new { }
                );
        }

        public async Task<PacienteModel?> GetByIdAsync(int id)
        {
            var pacientes = await _dataAccess.GetDataAsync<PacienteModel, dynamic>(
                "spPaciente_GetByID",
                new { PacienteID = id }
                );

            return pacientes.FirstOrDefault();
        }

        public async Task EditAsync(PacienteModel paciente)
        {
            await _dataAccess.SaveDataAsync(
                "spPaciente_Update",
                paciente
                );
        }

        public async Task DeleteAsync(int id)
        {
            await _dataAccess.SaveDataAsync(
                "spPaciente_Delete",
                new { PacienteID = id }
                );
        }

        public async Task AddAsync(PacienteModel paciente)
        {
            await _dataAccess.SaveDataAsync(
                "spPaciente_Insert",
                new { paciente.NombrePaciente, paciente.ApellidoPaciente, paciente.FechaNacimiento, paciente.Sexo, paciente.Telefono, paciente.Email, paciente.FechaRegistro });
        }

    }
}
