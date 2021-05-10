using System.Collections.Generic;
using App.Database.Models;

namespace App.ViewModels
{
    public class RoleViewModel
    {
        public List<User> BossUsers { get; set; }
        public List<User> RegularUsers { get; set; }
    }
}