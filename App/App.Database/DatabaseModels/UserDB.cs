using System.Collections.Generic;

namespace App.Database.DatabaseModels
{
    public class UserDB
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public string Nickname { get; set; }
        public  List<ProjectDB> Projects { get; set; }
    }
}