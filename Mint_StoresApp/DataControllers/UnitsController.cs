using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class UnitsController
    {
        public async Task<List<MeasurementUnit>> SelectUnits()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<MeasurementUnit>(
                    DatabaseConstans.SelectUnits,
                    commandType: CommandType.StoredProcedure
                    );
                return rows.ToList();
            }
        }
        public async Task<bool> InsertUnit(MeasurementUnit unit)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<MeasurementUnit>(
                    DatabaseConstans.InsertUnit,
                    new { Name = unit.Name },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> DeleteUnit(MeasurementUnit unit)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<MeasurementUnit>(
                    DatabaseConstans.DeleteUnit,
                    new { Id = unit.Id },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> UpdateUnit(MeasurementUnit unit)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<MeasurementUnit>(
                    DatabaseConstans.UpdateUnit,
                    new { Id = unit.Id, Name = unit.Name },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
