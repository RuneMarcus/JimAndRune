using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Context
{
    [Table("Lokaler")]
    public class Lokale
    {
        public int lokaleID { get; set; }
        public string addresse { get; set; }
        public string postnummer { get; set; }
        public int areal { get; set; }
        public int pladsTil { get; set; }
    }
}