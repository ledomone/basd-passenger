using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class Driver
    {
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Vehicle vehicle { get; protected set; }
        protected IEnumerable<Route> Routes { get; private set; }
        
    }
}