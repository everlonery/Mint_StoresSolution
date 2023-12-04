namespace Mint_StoresApp.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int ZipCode { get; set; }
        public int CityId { get; set; }
    }
}
