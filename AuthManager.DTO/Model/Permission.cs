using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.DTO.Model
{
    public class Permission : BaseEntity
    {
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Path { get; set; }
        public ICollection<UserPermission> Users { get; set; }
        public ICollection<RolePermission> Roles { get; set; }
    }
}
