using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Context;

namespace BookingProgram
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            using (var ctx = new BookingContext())
            {
                Bruger user = new Bruger()
                {
                    fornavn = "Rune",
                    efternavn = "Marcuslund",
                    addresse = "Vesterbrogade 3",
                    email = "rune.marcus@gmail.com",
                    telefon = "13377331",
                    password = "1234",
                    administrator = true
                };

                ctx.Brugere.Add(user);
                ctx.SaveChanges();
            }

            using (var ctx = new BookingContext())
            {
                Lokale lokale = new Lokale()
                {
                    areal = 54,
                    pladsTil = 3,
                    addresse = "Vesterbrogade 3",
                    postnummer = "6000",
                };

                ctx.Lokaler.Add(lokale);
                ctx.SaveChanges();
            }
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BookingGUI());
        }
    }
}
