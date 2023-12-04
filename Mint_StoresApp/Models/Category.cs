namespace Mint_StoresApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = String.Empty;
        public int ParentId { get; set; }
    }
}
