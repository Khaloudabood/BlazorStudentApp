
namespace EFDataAccessLibrary
{
    public interface ISqliteDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoudData<T, U>(string sqlite, U parameters);
        Task SaveData<T>(string Sqlite, T parameters);
    }
}