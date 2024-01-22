using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab.domain.entities
{
    public class Airport
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Adres { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

    }
}
