using System.Threading.Tasks;

namespace App.Services
{
    public interface ICheckInputService
    {
        Task<bool> UniqueUsername(Database.Models.User user);
    }
}