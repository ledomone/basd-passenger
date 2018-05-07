using System;
using System.Threading.Tasks;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public interface IDriverService : IService
    {
        Task<DriverDto> GetAsync(Guid userId);
        Task Create(Guid userId);
        Task SetVehicle(Guid userId, string brand, string name);
        Task Delete(Guid userId);
    }
}