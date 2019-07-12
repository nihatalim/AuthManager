using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.DTO.Model
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModified { get; set; }
        public BaseEntity()
        {
            this.DateCreation = DateTime.UtcNow;
            this.DateModified = DateTime.UtcNow;
        }
    }
}
