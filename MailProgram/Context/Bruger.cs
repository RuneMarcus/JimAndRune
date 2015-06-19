using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Context
{
    [Table("Brugere")]
    public class Bruger
    {
        public int brugerID {get; set;}
        public string password { get; set; }
        public string fornavn { get; set; }
        public string efternavn { get; set; }
        public string telefon { get; set; }
        //[Index(IsUnique=true)]
        public string email { get; set; }
        public string addresse { get; set; }
        public bool administrator { get; set; }
    }
}
