namespace Mint_StoresApp.Models
{
    public class EmploymentRecord
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int UserId { get; set; }
        public DateTime EmploymentDate { get; set; } = DateTime.Now.Date;
        public DateTime? TerminationDate { get; set; } = null;
    }
}
