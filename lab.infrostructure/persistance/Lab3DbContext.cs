using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab.domain.entities;


namespace lab.infrostructure.persistance
{
    public class Lab3DbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Fly> Fly { get; set; }
        public DbSet<Airport> Airport { get; set; }
        public DbSet<Booking> Booking{ get; set; }
        public DbSet<Pilot> Pilot { get; set; }
        public DbSet<Plane> Plane { get; set; }

        public Lab3DbContext(DbContextOptions<Lab3DbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
