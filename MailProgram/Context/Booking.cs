using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class Booking
    {
        //BookingPrimary
        public int BookingID { get; set; }

        //bruger
        public virtual Bruger Bruger { get; set; }

        //lokaler
        public virtual Lokale Lokale { get; set; }

        //booking attributes
        public DateTime startTidspunkt { get; set; }
        public DateTime slutTidspunkt { get; set; }
        public bool godkendt { get; set; }
    }
}
