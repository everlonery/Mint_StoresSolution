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

        public async Task<bool> InsertCity(City city)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<City>(
                    DatabaseConstans.InsertCity,
                    new { Name = city.Name },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> DeleteCity(City city)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<City>(
                    DatabaseConstans.DeleteCity,
                    new { CityId = city.CityId },
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
                    new { StoreId = store.StoreId, Name = store.Name, Phone = store.Phone, Email = store.Email, Address = store.Address, ZipCode = store.ZipCode, CityId = store.CityId},
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
