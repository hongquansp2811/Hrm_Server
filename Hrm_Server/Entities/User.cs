using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? EmployeeId { get; set; }
        public string Role { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public User()
        {
            CreatedDate = DateTime.Now;
            IsActive = true;
            Role = "Employee";
        }
    }
} 