using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Models
{
    public abstract class BaseEntity
    {
        [Key]
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
