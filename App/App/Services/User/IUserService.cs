using System.Threading.Tasks;
using App.ViewModels;

namespace App.Services.User
{
    public interface IUserService
    {
        Task<Database.Models.User> GetUserById(int id);
        Task<Database.Models.User> GetUserByNickname(string name);
        Task<bool> UpdateUserData(Database.Models.User user);
        Task<bool> UpdateUserPassword(string password, string newPassword, int userId);
    }
}