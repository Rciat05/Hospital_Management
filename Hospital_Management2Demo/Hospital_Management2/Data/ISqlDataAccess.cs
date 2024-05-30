using System.Data;

namespace Hospital_Management2.Data
{
    public interface ISqlDataAccess
    {
        IDbConnection GetConnection();
    }
}