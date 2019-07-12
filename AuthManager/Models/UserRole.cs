using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Models
{
    public class UserRole : BaseEntity
    {
        public Role Role { get; set; }
        public int RoleID { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
    }
}
