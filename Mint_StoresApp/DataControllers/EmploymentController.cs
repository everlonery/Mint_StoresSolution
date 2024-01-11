using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class EmploymentController
    {
        public async Task<IEnumerable<EmploymentRecord>> Select()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<EmploymentRecord>(
                    DatabaseConstans.SelectEmployment,
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }

        public async Task<bool> Insert(EmploymentRecord record)
        {
            try
            {
                using (var connection = DatabaseConstans.GetConnection())
                {
                    connection.Open();
                    var rows = await connection.QueryAsync<EmploymentRecord>(
                        DatabaseConstans.InsertEmployment,
                        new { StoreId = record.StoreId==0? null : (int?)record.StoreId, UserId = record.UserId== 0 ? null : (int?)record.UserId, EmploymentDate = record.EmploymentDate, TerminationDate = record.TerminationDate },
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

        public async Task<bool> Delete(EmploymentRecord record)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<EmploymentRecord>(
                    DatabaseConstans.DeleteEmployment,
                    new { Id = record.Id },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> Update(EmploymentRecord record)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<EmploymentRecord>(
                    DatabaseConstans.UpdateEmployment,
                    new { Id = record.Id ,StoreId = record.StoreId == 0 ? null : (int?)record.StoreId, UserId = record.UserId == 0? null: (int?)record.UserId, EmploymentDate = record.EmploymentDate, TerminationDate = record.TerminationDate },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
