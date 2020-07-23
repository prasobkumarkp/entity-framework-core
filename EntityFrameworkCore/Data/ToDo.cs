namespace EntityFrameworkCore.Data
{
    public class ToDo:BaseEntity
    {
        public string Text { get; set; }
        public bool Completed { get; set; }
    }
}
