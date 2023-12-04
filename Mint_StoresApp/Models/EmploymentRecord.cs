namespace Mint_StoresApp.Models
{
    public class EmploymentRecord
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int UserId { get; set; }
        public DateOnly EmploymentDate { get; set; }
        public DateOnly TerminationDate { get; set; }
    }
}
