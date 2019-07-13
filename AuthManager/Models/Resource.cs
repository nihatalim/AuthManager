using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Models
{
    public class Resource : BaseEntity
    {
        public string Name { get; set; }
        public string Detail { get; set; }
        public ICollection<ResourceRequirement> Requirements { get; set; }
    }
}
