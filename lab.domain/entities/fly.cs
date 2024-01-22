using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.domain.entities
{
    public class Fly
    {
        public Guid Id { get; set; }
        public Airport From { get; set; }
        public Guid AirportFromId { get; set; }
        public Airport To { get; set; }
        public Guid AirportToId { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public string Where { get; set; }
        public Guid PlaneId { get; set; }
        public Plane Plane { get; set; }

    }
}
