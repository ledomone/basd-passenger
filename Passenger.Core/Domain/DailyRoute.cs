using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class DailyRoute
    {
        public Guid Id { get; set; }
        public Route Route { get; set; }
        public IEnumerable<PassengerNode> PassengerNodes { get; protected set; }
    }
}