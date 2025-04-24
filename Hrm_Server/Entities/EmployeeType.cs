using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("EmployeeType")]
    public class EmployeeType
    {
        [Key]
        public int EmployeeTypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
    }
} 