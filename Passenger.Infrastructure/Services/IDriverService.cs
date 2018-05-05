using System;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public interface IDriverService : IService
    {
        DriverDto GetDriver(Guid userId);
        void Create(Guid userId);
        void SetVehicle(Guid userId, string brand, string name);
        void Delete(Guid userId);
    }
}