using System.Threading.Tasks;
using App.Database.Project;
using App.Database.User;
using App.Services.Project;

namespace App.Services.User
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICheckInputService _checkInputService;

        public RegistrationService(IUserRepository userRepository, ICheckInputService checkInputService)
        {
            _userRepository = userRepository;
            _checkInputService = checkInputService;
        }

        public async Task<int> AddUser(Database.Models.User user)
        {
            var uniqueNickname = await _checkInputService.UniqueUsername(user);
            if (!uniqueNickname) return 0;
            var id = await _userRepository.AddUserAsync(user);
            return id;

        }
    }
}