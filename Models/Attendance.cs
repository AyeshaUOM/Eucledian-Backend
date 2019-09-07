using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Etudiant.Models
{
    public class Attendance
    {
        public Attendance()
        {
            AccessDate = new DateTime().ToUniversalTime();
        }
        public int Id { get; set; }

        public Student student { get; set; }

        public Branch branch { get; set; }

        public DateTime AccessDate { get; set; }

        public VeryfyMode veryfyMode { get; set; }

        [DefaultValue(false)]
        public bool Edit { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

        public Class Class { get; set; }

        public List<Attendance> AttendanceList { get; private set; }
        public enum VeryfyMode
        {
            In = 0,
            Out = 1
        }
    }
}
