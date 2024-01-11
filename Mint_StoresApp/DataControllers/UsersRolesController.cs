using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class UsersRolesController
    {
        public async Task<IEnumerable<UserRole>> Select()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<UserRole>(
                    DatabaseConstans.SelectUsersRoles,
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }

        public async Task<bool> Insert(UserRole record)
        {
            try
            {
                using (var connection = DatabaseConstans.GetConnection())
                {
                    connection.Open();
                    var rows = await connection.QueryAsync<UserRole>(
                        DatabaseConstans.InsertUserRole,
                        new { UserId = record.UserId==0?null:(int?)record.UserId, RoleId = record.RoleId==0?null:(int?)record.RoleId},
                        commandType: CommandType.StoredProcedure
                        );
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public async Task<bool> Delete(UserRole record)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<UserRole>(
                    DatabaseConstans.DeleteUserRole,
                    new { Id = record.Id },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> Update(UserRole record)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<UserRole>(
                    DatabaseConstans.UpdateUserRole,
                    new { Id = record.Id, UserId = record.UserId == 0 ? null : (int?)record.UserId, RoleId = record.RoleId == 0 ? null : (int?)record.RoleId },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
