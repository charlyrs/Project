using System.Collections.Generic;

namespace App.Database.DatabaseModels
{
    public class CommentDB
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ProjectTaskDB Task { get; set; }
        public UserDB User { get; set; }
    }
}