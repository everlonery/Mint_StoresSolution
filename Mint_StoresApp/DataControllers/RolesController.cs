using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class RolesController
    {
        public async Task<List<Role>> SelectRoles()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Role>(
                    DatabaseConstans.SelectRoles,
                    commandType: CommandType.StoredProcedure
                    );
                return rows.ToList();
            }
        }
        public async Task<bool> InsertRole(Role role)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Role>(
                    DatabaseConstans.InsertRole,
                    new { Name = role.Name },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> DeleteRole(Role role)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Role>(
                    DatabaseConstans.DeleteRole,
                    new { RoleId = role.RoleId },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> UpdateRole(Role role)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Role>(
                    DatabaseConstans.UpdateRole,
                    new { RoleId = role.RoleId, Name = role.Name },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
