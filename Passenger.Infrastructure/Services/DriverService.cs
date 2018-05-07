using System;
using System.Threading.Tasks;
using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IMapper _mapper;
        public DriverService(IDriverRepository driverRepository, IMapper mapper)
        {
            _driverRepository = driverRepository;
            _mapper = mapper;
        }

        public async Task Create(Guid userId)
        {
            await Task.CompletedTask;
        }

        public async Task Delete(Guid userId)
        {
            var driver = await _driverRepository.GetAsync(userId);
            await _driverRepository.RemoveAsync(driver);
        }

        public async Task<DriverDto> GetAsync(Guid userId)
        {
            var driver = await _driverRepository.GetAsync(userId);
            return _mapper.Map<Driver, DriverDto>(driver);
        }

        public async Task SetVehicle(Guid userId, string brand, string name)
        {
            await Task.CompletedTask;
        }

    }
}