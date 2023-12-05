using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class CategoriesController
    {
        public async Task<List<Category>> SelectCategories()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Category>(
                    DatabaseConstans.SelectCategories,
                    commandType: CommandType.StoredProcedure
                    );
                return rows.ToList();
            }
        }

        public async Task<Category> SelectParent(Category child)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Category>(
                    DatabaseConstans.SelectCategory,
                    new {CategoryId = child.ParentId},
                    commandType: CommandType.StoredProcedure
                    );
                return rows.First();
            }
        }

        public async Task<bool> InsertCategory(Category category)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Category>(
                    DatabaseConstans.InsertCategory,
                    new { Name = category.Name, ParentId = category.ParentId },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> DeleteCategory(Category category)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Category>(
                    DatabaseConstans.DeleteCategory,
                    new { CategoryId = category.CategoryId },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> UpdateCategory(Category category)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Category>(
                    DatabaseConstans.UpdateCategory,
                    new { CategoryId = category.CategoryId, Name = category.Name },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
