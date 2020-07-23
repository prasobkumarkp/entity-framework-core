namespace EntityFrameworkCore.Data
{
    public class Contact:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
