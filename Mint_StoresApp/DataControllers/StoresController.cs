using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class StoresController
    {
        public async Task<IEnumerable<Store>> SelectStores()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Store>(
                    DatabaseConstans.SelectStores,
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }

        public async Task<bool> InsertStore(Store store)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Store>(
                    DatabaseConstans.InsertStore,
                    new { Name = store.Name, Phone = store.Phone, Email = store.Email, Address = store.Address, ZipCode = store.ZipCode, CityId = store.CityId==0?null:(int?)store.CityId},
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> DeleteStore(Store store)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Store>(
                    DatabaseConstans.DeleteStore,
                    new { StoreId = store.StoreId },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> UpdateStore(Store store)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Store>(
                    DatabaseConstans.UpdateStore,
                    new { StoreId = store.StoreId, Name = store.Name, Phone = store.Phone, Email = store.Email, Address = store.Address, ZipCode = store.ZipCode, CityId = store.CityId == 0 ? null : (int?)store.CityId },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
