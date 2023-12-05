using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class GroupsController
    {
        public async Task<List<TaxGroup>> SelectGroups()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<TaxGroup>(
                    DatabaseConstans.SelectGroups,
                    commandType: CommandType.StoredProcedure
                    );
                return rows.ToList();
            }
        }
        public async Task<bool> InsertGroup(TaxGroup group)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<TaxGroup>(
                    DatabaseConstans.InsertGroup,
                    new { Name = group.Name },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> DeleteGroup(TaxGroup group)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<TaxGroup>(
                    DatabaseConstans.DeleteGroup,
                    new { Id = group.Id },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> UpdateGroup(TaxGroup group)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<TaxGroup>(
                    DatabaseConstans.UpdateGroup,
                    new { Id = group.Id, Name = group.Name },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
