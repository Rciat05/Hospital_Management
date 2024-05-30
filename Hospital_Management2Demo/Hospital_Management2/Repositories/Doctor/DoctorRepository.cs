using Hospital_Management2.Data;
using Hospital_Management2.Models;

namespace Hospital_Management2.Repositories.Doctor
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ISqlDataAccess _dataAccess;

        public DoctorRepository(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<DoctorModel>> GetAllAsync()
        {
            return await _dataAccess.GetDataAsync<DoctorModel, dynamic>(
                "spDoctor_GetAll",
                new { }
                );
        }

        public async Task<DoctorModel?> GetByIdAsync(int id)
        {
            var doctores = await _dataAccess.GetDataAsync<DoctorModel, dynamic>(
                "spDoctor_GetByID",
                new { DoctorID = id }
                );

            return doctores.FirstOrDefault();
        }

        public async Task EditAsync(DoctorModel doctor)
        {
            await _dataAccess.SaveDataAsync(
                "spDoctor_Update",
                doctor
                );
        }

        public async Task DeleteAsync(int id)
        {
            await _dataAccess.SaveDataAsync(
                "spDoctor_Delete",
                new { DoctorID = id }
                );
        }

        public async Task AddAsync(DoctorModel doctor)
        {
            await _dataAccess.SaveDataAsync(
                "spDoctor_Insert",
                new { doctor.NombreDoctor, doctor.ApellidoDoctor, doctor.Especialidad, doctor.Telefono, doctor.Email, doctor.FechaContratacion, doctor.Estado });
        }

    }
}
