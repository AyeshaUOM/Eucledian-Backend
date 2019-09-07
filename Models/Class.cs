using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class Class
    {
        public int Id { get; set; }

        public string dayOfWeek { get; set; }

        public string timeOfDay { get; set; }

        [Required]
        public string name { get; set; }

        public string category { get; set; }

        [DefaultValue(true)]
        public bool isActive { get; set; }

        public User user { get; set; }

        public Branch branch { get; set; }
    }
}
