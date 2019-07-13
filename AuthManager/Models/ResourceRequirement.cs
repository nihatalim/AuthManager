using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Models
{
    public class ResourceRequirement : BaseEntity
    {
        public int ResourceID { get; set; }
        public Resource Resource { get; set; }
        public int RequirementID { get; set; }
        public Permission Requirement { get; set; }
    }
}
