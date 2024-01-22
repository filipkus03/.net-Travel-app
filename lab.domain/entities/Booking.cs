using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace lab.domain.entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid FlyId { get; set; }
        public IdentityUser User { get; set; }

    }
}
