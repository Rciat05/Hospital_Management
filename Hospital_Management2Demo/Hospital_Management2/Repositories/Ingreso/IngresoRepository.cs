using Hospital_Management2.Data;
using Hospital_Management2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var ingresos = await _dataAccess.GetDataAsync<IngresoModel, dynamic>(
                "spIngreso_GetAll",
                new { }
            );

            return ingresos;
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
            // Obtener el ID del paciente basado en el nombre y apellido
            int? pacienteId = await GetPacienteIdAsync(ingreso.NombrePaciente, ingreso.ApellidoPaciente);
            if (pacienteId == null)
            {
                throw new Exception("Paciente no encontrado");
            }

            // Obtener el ID de la habitación basado en el número de habitación
            int? habitacionId = await GetHabitacionIdAsync(ingreso.NumeroHabitacion);
            if (habitacionId == null)
            {
                throw new Exception("Habitación no encontrada");
            }

            await _dataAccess.SaveDataAsync(
                "spIngreso_Insert",
                new
                {
                    PacienteID = pacienteId,
                    HabitacionID = habitacionId,
                    ingreso.FechaIngreso,
                    ingreso.FechaAlta,
                    ingreso.DiagnosticoInicial,
                    ingreso.EstadoIngresos
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

        private async Task<int?> GetHabitacionIdAsync(string numeroHabitacion)
        {
            var habitacion = await _dataAccess.GetDataAsync<int, dynamic>(
                "spGetHabitacionByNumero",
                new { NumeroHabitacion = numeroHabitacion }
            );

            return habitacion.FirstOrDefault();
        }
    }
}
