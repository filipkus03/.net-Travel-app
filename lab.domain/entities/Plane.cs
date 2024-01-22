using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.domain.entities
{
    public class Plane
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool InAir { get; set; }

    }
}
