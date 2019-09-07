using System;
using System.ComponentModel;

namespace Etudiant.Models
{
    public class StudentClass
    {
        public int Id { get; set; }

        public Student student { get; set; }

        public Class Class { get; set; }

        public DateTime datetime { get; set; }

        [DefaultValue(false)]
        public bool active { get; set; }

        public User user { get; set; }

        [DefaultValue(false)]
        public bool status { get; set; }

        public StudentClass()
        {
            datetime = new DateTime().ToUniversalTime();
        }
    }
}
