namespace App.Database.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ProjectTask Task { get; set; }
        public User User { get; set; }
    }
}