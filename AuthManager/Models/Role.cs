using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Models
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Detail { get; set; }
        public ICollection<UserRole> Users { get; set; }
        public ICollection<RolePermission> Permissions { get; set; }
    }
}
