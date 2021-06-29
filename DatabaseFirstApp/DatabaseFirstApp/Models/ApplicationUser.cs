using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirstApp.Models
{
    public class ApplicationUser: IdentityUser
    {
        public DateTimeOffset CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset LastModifiedAt { get; set; }
        public bool isDeleted { get; set; }
        public String DeleteReason { get; set; }
        [ForeignKey("CreatedBy")]
        public virtual ApplicationUser User { get; set; }
    }
}
