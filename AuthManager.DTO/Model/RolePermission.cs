using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.DTO.Model
{
    public class RolePermission : BaseEntity
    {
        public Role Role { get; set; }
        public int RoleID { get; set; }
        public Permission Permission { get; set; }
        public int PermissionID { get; set; }
    }
}
