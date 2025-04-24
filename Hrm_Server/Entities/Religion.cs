using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Religion")]
    public class Religion
    {
        [Key]
        public int ReligionId { get; set; }
        public string ReligionName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public Religion()
        {
            Employees = new HashSet<Employee>();
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
    }
} 