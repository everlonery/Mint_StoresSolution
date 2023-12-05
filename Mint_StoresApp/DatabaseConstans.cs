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
        #region Roles
        public const string SelectRoles = "sp_Roles_Select";
        public const string InsertRole = "sp_Roles_Insert";
        public const string DeleteRole = "sp_Roles_Delete";
        public const string UpdateRole = "sp_Roles_Update";
        #endregion
        #region Units
        public const string SelectUnits = "sp_Units_Select";
        public const string InsertUnit = "sp_Units_Insert";
        public const string DeleteUnit = "sp_Units_Delete";
        public const string UpdateUnit = "sp_Units_Update";
        #endregion
    }
}
