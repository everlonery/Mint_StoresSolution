namespace Mint_StoresApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = String.Empty;
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsForAdults { get; set; }
        public bool IsExcise { get; set; }
        public string? PicturePath { get; set; }
    }
}
