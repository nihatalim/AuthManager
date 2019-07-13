using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Models
{
    public class User : BaseEntity
    {
        public string Token { get; set; }
        public ICollection<UserPermission> Permissions { get; set; }
        public ICollection<UserRole> Roles { get; set; }
    }
}
