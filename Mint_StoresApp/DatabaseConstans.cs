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
        #region Stores
        public const string SelectStores = "sp_Stores_Select";
        public const string InsertStore = "sp_Stores_Insert";
        public const string DeleteStore = "sp_Stores_Delete";
        public const string UpdateStore = "sp_Stores_Update";
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
        #region Groups
        public const string SelectGroups = "sp_Groups_Select";
        public const string InsertGroup = "sp_Groups_Insert";
        public const string DeleteGroup = "sp_Groups_Delete";
        public const string UpdateGroup = "sp_Groups_Update";
        #endregion
        #region Users
        public const string SelectUsers = "sp_Users_Select";
        public const string InsertUser = "sp_Users_Insert";
        public const string DeleteUser = "sp_Users_Delete";
        public const string UpdateUser = "sp_Users_Update";
        #endregion
        #region Categories
        public const string SelectCategories = "sp_Categories_Select";
        public const string SelectCategory = "sp_Categories_SelectById";
        public const string InsertCategory = "sp_Categories_Insert";
        public const string DeleteCategory = "sp_Categories_Delete";
        public const string UpdateCategory = "sp_Categories_Update";
        #endregion
    }
}
