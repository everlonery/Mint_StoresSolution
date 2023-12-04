using System.Data.SqlClient;

namespace Mint_StoresApp
{
    public static class DatabaseConstans
    {
        const string ConnectionString = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=Mint_StoresDatabase;Persist Security Info=False;User ID=sa;Password=12345678";
        public static SqlConnection GetConnection() => new(ConnectionString);

        #region Cities
        public const string SelectCities = "sp_Cities_Select";
        public const string InsertCity = "sp_Cities_Insert";
        public const string DeleteCity = "sp_Cities_Delete";
        public const string UpdateCity = "sp_Cities_Update";
        #endregion
    }
}
