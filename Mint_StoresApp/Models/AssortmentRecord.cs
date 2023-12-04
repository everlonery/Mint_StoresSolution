namespace Mint_StoresApp.Models
{
    public class AssortmentRecord
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UnitId { get; set; }
        public int TaxGroupId { get; set; }
    }
}
