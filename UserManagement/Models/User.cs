namespace UserManagement.Models
{
    public class User
    {
        public int ID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Mobile { get; set; }
        public DateTime Birthday { get; set; }
        public int Gender { get; set; }
        public int Active { get; set; } 

    }
}
