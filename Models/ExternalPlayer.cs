using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class ExternalPlayer
    {
        public int Id { get; set; }
        public string NICNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string gender { get; set; }
    }
}
