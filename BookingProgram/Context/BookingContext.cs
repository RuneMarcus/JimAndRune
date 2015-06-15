using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Context
{
    public class BookingContext : DbContext
    {
        public BookingContext() : base()
        {

        }
        public DbSet<Bruger> Brugere { get; set; }
        public DbSet<Lokale> Lokaler { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        
    }
}
