using System;
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

        public void Create(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid userId)
        {
            throw new NotImplementedException();
        }

        public DriverDto Get(Guid userId)
        {
            var driver = _driverRepository.Get(userId);
            return _mapper.Map<Driver, DriverDto>(driver);
        }

        public void SetVehicle(Guid userId, string brand, string name)
        {
            throw new NotImplementedException();
        }
    }
}