
namespace Hospital_Management2.Data
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> GetDataAsync<T, P>(string storedProcedure, P parameters, string connection = "default");
        Task SaveDataAsync<T>(string storedProcedure, T parameters, string connection = "default");
    }
}