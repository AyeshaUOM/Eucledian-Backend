using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string CompanyName { get; set; }

    }
}
