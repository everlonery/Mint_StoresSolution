using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class AssortmentController
    {
        public async Task<IEnumerable<AssortmentRecord>> Select()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<AssortmentRecord>(
                    DatabaseConstans.SelectAssortment,
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }

        public async Task<bool> Insert(AssortmentRecord record)
        {
            try
            {
                using (var connection = DatabaseConstans.GetConnection())
                {
                    connection.Open();
                    var rows = await connection.QueryAsync<AssortmentRecord>(
                        DatabaseConstans.InsertAssortment,
                        new { StoreId = record.StoreId==0?null:(int?)record.StoreId, ProductId = record.ProductId==0?null:(int?)record.ProductId, Quantity = record.Quantity, UnitId = record.UnitId == 0 ? null : (int?)record.UnitId, TaxGroupId = record.TaxGroupId==0?null:(int?)record.TaxGroupId},
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

        public async Task<bool> Delete(AssortmentRecord record)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<AssortmentRecord>(
                    DatabaseConstans.DeleteAssortment,
                    new { Id = record.Id },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> Update(AssortmentRecord record)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<AssortmentRecord>(
                    DatabaseConstans.UpdateAssortment,
                    new { StoreId = record.StoreId == 0 ? null : (int?)record.StoreId, ProductId = record.ProductId == 0 ? null : (int?)record.ProductId, Quantity = record.Quantity, UnitId = record.UnitId == 0 ? null : (int?)record.UnitId, TaxGroupId = record.TaxGroupId == 0 ? null : (int?)record.TaxGroupId },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
