using System.Threading.Tasks;
using App.Database.User;

namespace App.Services
{
    public class CheckInputService : ICheckInputService
    {
        private readonly IUserRepository _userRepository;

        public CheckInputService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> UniqueUsername(Database.Models.User user)
        {
            var foundUser = await _userRepository.GetUserByNickname(user.Nickname);
            if (foundUser == null)
            {
                return true;
            }
            return false;
        }
    }
}