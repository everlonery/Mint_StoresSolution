using Dapper;
using Mint_StoresApp.Models;
using System.Data;

namespace Mint_StoresApp.DataControllers
{
    public class ProductsController
    {
        public async Task<IEnumerable<Product>> SelectProducts()
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Product>(
                    DatabaseConstans.SelectProducts,
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }

        public async Task<bool> InsertProduct(Product product)
        {
            try
            {
                using (var connection = DatabaseConstans.GetConnection())
                {
                    connection.Open();
                    var rows = await connection.QueryAsync<Product>(
                        DatabaseConstans.InsertProduct,
                        new { Name = product.Name, Price = product.Price, CategoryId = product.CategoryId==0?null:(int?)product.CategoryId, IsForAdults = product.IsForAdults, IsExcise = product.IsExcise, PicturePath = product.PicturePath},
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
        public async Task<bool> DeleteProduct(Product product)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Product>(
                    DatabaseConstans.DeleteProduct,
                    new { ProductId = product.ProductId },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public async Task<bool> UpdateProduct(Product product)
        {
            using (var connection = DatabaseConstans.GetConnection())
            {
                connection.Open();
                var rows = await connection.QueryAsync<Product>(
                    DatabaseConstans.UpdateProduct,
                    new { ProductId = product.ProductId ,Name = product.Name, Price = product.Price, CategoryId = product.CategoryId == 0 ? null : (int?)product.CategoryId, IsForAdults = product.IsForAdults, IsExcise = product.IsExcise, PicturePath = product.PicturePath },
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
