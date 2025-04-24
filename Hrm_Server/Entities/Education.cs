using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Education")]
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        public string EducationName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public Education()
        {
            Employees = new HashSet<Employee>();
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
    }
} 