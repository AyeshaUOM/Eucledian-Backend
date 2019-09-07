using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class Branch
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public List<User> Users { get; private set; }

        public List<Student> Students { get; private set; }
       
        public DateTime CRTDatetime { get; set; }

        public string Description { get; set; }

        public Branch()
        {
            // Users = new List<User>();
            Users = new List<User>();
            Students = new List<Student>();
            CRTDatetime = new DateTime().ToUniversalTime();

        }

    }
}
