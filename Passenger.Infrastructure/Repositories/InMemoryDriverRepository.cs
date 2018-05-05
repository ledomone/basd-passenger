using System;
using System.Collections.Generic;
using System.Linq;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;

namespace Passenger.Infrastructure.Repositories
{
    public class
    InMemoryDriverRepository : IDriverRepository
    {

        private static ISet<Driver> _drivers = new HashSet<Driver>
        {
        };

        public void Add(Driver driver)
        {
            _drivers.Add(driver);
        }

        public void Update(Driver driver)
        {
            throw new NotImplementedException();
        }

        Driver IDriverRepository.Get(Guid userId)
            => _drivers.Single(x => x.UserId == userId);

        IEnumerable<Driver> IDriverRepository.GetAll()
            => _drivers;
    }
}