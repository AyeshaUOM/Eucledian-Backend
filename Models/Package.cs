using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class Package
    {
        public int Id { get; set; }

        public string packageName { get; set; }

        public int noOfMonths { get; set; }

        public decimal precentage { get; set; }

        public bool isAdmissionWaveOff { get; set; }

        [DefaultValue(true)]
        public bool isActive { get; set; }

        public Branch branch { get; set; }
    }
}
