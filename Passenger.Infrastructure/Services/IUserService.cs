using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public interface IUserService : IService
    {
        UserDto Get(string email);
        void Register(string email, string username, string password);
    }
}