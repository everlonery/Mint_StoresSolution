namespace Mint_StoresApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string LastName { get; set; } = String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public string ParentName { get; set; } = String.Empty;
        public DateOnly BirthDate { get; set; }
        public bool IsActive { get; set; }
        public string Phone { get; set; } = String.Empty;
        public string? Email { get; set; }
    }
}
