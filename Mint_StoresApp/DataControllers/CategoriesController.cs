﻿using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class CategoriesController
    {
        public async Task<IEnumerable<Category>> SelectCategories()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Category>(
                    DatabaseConstans.SelectCategories,
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }

        public async Task<bool> InsertCategory(Category category)
        {
            try
            {
                using (var connection = DatabaseConstans.GetConnection())
                {
                    connection.Open();
                    var rows = await connection.QueryAsync<Category>(
                        DatabaseConstans.InsertCategory,
                        new { Name = category.Name, ParentId = category.ParentId==0 ? null: (int?)category.ParentId },
                        commandType: CommandType.StoredProcedure
                        );
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine( ex.ToString());
                return false;
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
                    new { CategoryId = category.CategoryId, Name = category.Name, ParentId = category.ParentId == 0 ? null : (int?)category.ParentId },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
