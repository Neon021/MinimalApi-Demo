namespace DataAccess.DBAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<U>> LoadData<U, T>(string storedProcedures, T parametres, string connectionID = "Default");
        Task SaveData<T>(string storedProcedures, T parametres, string connectionID = "Default");
    }
}