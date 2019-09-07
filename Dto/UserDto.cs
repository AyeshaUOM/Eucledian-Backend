using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Dto
{
    public class UserDto
    {
        public string JWT { get; set; }
        public int? UserID { get; set; }
        public string UserRole { get; set; }
        public int? BranchId { get; set; }
    }
}
