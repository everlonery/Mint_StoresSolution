using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class UsersController
    {
        public async Task<List<User>> SelectUsers()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<User>(
                    DatabaseConstans.SelectUsers,
                    commandType: CommandType.StoredProcedure
                    );
                return rows.ToList();
            }
        }
        public async Task<bool> InsertUser(User user)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<User>(
                    DatabaseConstans.InsertUser,
                    new { LastName = user.LastName,
                    FirstName = user.FirstName,
                    ParentName = user.ParentName,
                    BirthDate = user.BirthDate,
                    IsActive = user.IsActive,
                    Phone = user.Phone,
                    Email = user.Email
                    },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> DeleteUser(User user)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<User>(
                    DatabaseConstans.DeleteUser,
                    new { UserId = user.UserId },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> UpdateUser(User user)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<User>(
                    DatabaseConstans.UpdateUser,
                    new {UserId = user.UserId,
                        LastName = user.LastName,
                        FirstName = user.FirstName,
                        ParentName = user.ParentName,
                        BirthDate = user.BirthDate,
                        IsActive = user.IsActive,
                        Phone = user.Phone,
                        Email = user.Email
                    },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
