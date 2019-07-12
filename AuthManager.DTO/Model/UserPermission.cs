using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.DTO.Model
{
    public class UserPermission : BaseEntity
    {
        public User User { get; set; }
        public int UserID { get; set; }

        public Permission Permission { get; set; }
        public int PermissionID { get; set; }

    }
}
