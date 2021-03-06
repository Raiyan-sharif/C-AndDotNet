using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirstApp.Models
{
    public class ApplicationRole
    {

    }

    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Email { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset LastModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public bool isDeleted { get; set; }
        public String DeleteReason { get; set; }
        //public int OrganizationId { get; set; }
        [ForeignKey("CreatedBy")]
        protected virtual User Creator { get; set; }
        [ForeignKey("ModifiedBy")]
        protected virtual User Modifier { get; set; }
        //[ForeignKey("OrganizationId")]
        //protected virtual Organization Organization { get; set; }
    }

    public class Role
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String NormalizedName { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset LastModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public bool isDeleted { get; set; }
        public String DeleteReason { get; set; }
        //public int OrganizationId { get; set; }
        [ForeignKey("CreatedBy")]
        protected virtual User Creator { get; set; }
        [ForeignKey("ModifiedBy")]
        protected virtual User Modifier { get; set; }
    }

    public class RoleClaim
    {
        [Key]
        public int Id { get; set; }
        public String ClaimType { get; set; }
        public String ClaimValue { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public DateTimeOffset CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset LastModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public bool isDeleted { get; set; }
        public String DeleteReason { get; set; }
        //public int OrganizationId { get; set; }
        [ForeignKey("CreatedBy")]
        protected virtual User Creator { get; set; }
        [ForeignKey("ModifiedBy")]
        protected virtual User Modifier { get; set; }
        protected virtual Role Role { get; set; }
    }
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset LastModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public bool isDeleted { get; set; }
        public String DeleteReason { get; set; }
        //public int OrganizationId { get; set; }
        [ForeignKey("CreatedBy")]
        protected virtual User Creator { get; set; }
        [ForeignKey("ModifiedBy")]
        protected virtual User Modifier { get; set; }

        [ForeignKey("UserId")]
        protected virtual User User { get; set; }
        [ForeignKey("RoleId")]
        protected virtual Role Role { get; set; }
    }
    public class UserClaim
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public String ClaimType { get; set; }
        public String ClaimValue { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset LastModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public bool isDeleted { get; set; }
        public String DeleteReason { get; set; }
        //public int OrganizationId { get; set; }
        [ForeignKey("CreatedBy")]
        protected virtual User Creator { get; set; }
        [ForeignKey("ModifiedBy")]
        protected virtual User Modifier { get; set; }
        [ForeignKey("UserId")]
        protected virtual User User { get; set; }
    }
}
