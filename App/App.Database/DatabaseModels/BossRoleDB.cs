using System.Collections.Generic;

namespace App.Database.DatabaseModels
{
    public class BossRoleDB
    {
        public int Id { get; set; }
        public List<UserDB> BossUsers { get; set; }
        public ProjectDB Project { get; set; }
        public int ProjectDBId { get; set; }

        
    }
}