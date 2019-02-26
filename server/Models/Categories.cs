namespace Server.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public User User { get; set; }
    }
}