using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Etudiant.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        public string Password { get; set; }

        [Required]
        public RoleTypes Role { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

        public int? BranchId { get; set; }
        public Branch Branch { get; set; }
    }

    public enum RoleTypes
    {
        Admin = 99,
        Teachers = 91,
    }
}