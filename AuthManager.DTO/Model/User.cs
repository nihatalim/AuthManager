using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.DTO.Model
{
    public class User : BaseEntity
    {
        public List<UserPermission> Permissions { get; set; }
        public List<UserRole> Roles { get; set; }
    }
}
