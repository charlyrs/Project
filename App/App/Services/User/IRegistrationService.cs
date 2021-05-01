using System.Threading.Tasks;

namespace App.Services.User
{
    public interface IRegistrationService
    {
        Task<int> AddUser(Database.Models.User user);
    }
}