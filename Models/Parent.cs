using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Etudiant.Models
{
    public class Parent
    {
        public int Id { get; set; }

        public string FatherName { get; set; }
        public string FatherOccupation { get; set; }
        public string FatherOfficeAddress { get; set; }
        public string FatherMobileNumber { get; set; }

        public string MotherName { get; set; }
        public string MotherOccupation { get; set; }
        public string MotherOfficeAddress { get; set; }
        public string MotherMobileNumber { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        public string LandLineNumber { get; set; }
        public string SMSAlertNumber { get; set; }
        public string ParentType { get; set; }
        public List<Student> Students { get; set; }
    }
}
