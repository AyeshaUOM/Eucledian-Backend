using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etudiant.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string IndexNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AdmissionFee { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string School { get; set; }

        public string Grade { get; set; }

        public Class Class { get; set; }

        public string Photo { get; set; }

        public DateTime AdmissionDate { get; set; }

        public DateTime RegisterDate { get; set; }

        public string Note { get; set; }

        [DefaultValue(true)]
        public bool Status { get; set; }
        public string StudentType { get; set; }

        [ForeignKey("Parent")]
        public int ParentId { get; set; }
        public virtual Parent Parent { get; set; }

        public List<StudentClass> StudentClass { get; private set; }

        public Student()
        {
            RegisterDate = new DateTime().ToUniversalTime();
        }
    }
}