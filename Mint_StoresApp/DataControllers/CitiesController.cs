using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class CitiesController
    {
        public async Task<List<City>> SelectCities()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<City>(
                    DatabaseConstans.SelectCities,
                    commandType: CommandType.StoredProcedure
                    );
                return rows.ToList();
            }
        }
        public async Task<bool> InsertCity(City city)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<City>(
                    DatabaseConstans.InsertCity,
                    new {Name = city.Name},
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
        public async Task<bool> UpdateCity(City city)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<City>(
                    DatabaseConstans.UpdateCity,
                    new { CityId = city.CityId, Name = city.Name},
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
