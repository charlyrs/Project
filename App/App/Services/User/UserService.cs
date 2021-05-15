using System;
using System.Threading.Tasks;
using App.Database.User;
using App.ViewModels;

namespace App.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICheckInputService _checkInputService;
        public UserService(IUserRepository userRepository, ICheckInputService checkInputService)
        {
            _userRepository = userRepository;
            _checkInputService = checkInputService;

        }
        public async Task<Database.Models.User> GetUserById(int id)
        {
            var user =  await _userRepository.GetUserByIdAsync(id);
            user.Projects = await _userRepository.GetProjects(user);
            return user;
        }

        public async Task<Database.Models.User> GetUserByNickname(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new Exception("Name can't be empty");
            var user = await _userRepository.GetUserByNickname(name);
            return user;
        }

        public  async Task<bool> UpdateUserData(Database.Models.User user)
        {
            var unique = await _checkInputService.UniqueUsername(user);
            if (!unique) return false;
            await _userRepository.UpdateUserAsync(user);
            return true;
        }

        public async Task<bool> UpdateUserPassword(string password, string newPassword, int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user.Password != password) return false;
            user.Password = newPassword;
            await _userRepository.UpdateUserAsync(user);
            return true;

        }
    }
}