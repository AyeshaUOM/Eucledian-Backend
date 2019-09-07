using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Etudiant.Models
{
    public class School
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Division { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }
    }
}