using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Venue { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public double InternalFee { get; set; }
        public double ExternalFee { get; set; }
        public string Description { get; set; }
    }
}
