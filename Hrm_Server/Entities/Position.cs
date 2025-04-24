using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Position")]
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public string Description { get; set; }
        public decimal Allowance { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<WorkHistory> WorkHistories { get; set; }
        public virtual ICollection<Transfer> FromPositions { get; set; }
        public virtual ICollection<Transfer> ToPositions { get; set; }

        public Position()
        {
            Employees = new HashSet<Employee>();
            WorkHistories = new HashSet<WorkHistory>();
            FromPositions = new HashSet<Transfer>();
            ToPositions = new HashSet<Transfer>();
            CreatedDate = DateTime.Now;
            IsActive = true;
            Allowance = 0;
        }
    }
} 