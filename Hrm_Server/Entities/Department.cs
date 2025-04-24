using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<WorkHistory> WorkHistories { get; set; }
        public virtual ICollection<Transfer> FromDepartments { get; set; }
        public virtual ICollection<Transfer> ToDepartments { get; set; }

        public Department()
        {
            Employees = new HashSet<Employee>();
            WorkHistories = new HashSet<WorkHistory>();
            FromDepartments = new HashSet<Transfer>();
            ToDepartments = new HashSet<Transfer>();
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
    }
} 