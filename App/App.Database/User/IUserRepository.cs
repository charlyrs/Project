using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.Models;

namespace App.Database.User
{
    public interface IUserRepository
    {
        Task<List<Models.Project>> GetProjects(Models.User user);
        Task<Models.User> GetUserByNickname(string name);
        Task<Models.User> GetUserByIdAsync(int id);
        Task<int> AddUserAsync(Models.User user);
        Task<bool> UpdateUserAsync(Models.User user);
    }
}