using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Assignment")]
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }

        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public int? AssignedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee AssignedByEmployee { get; set; }

        public Assignment()
        {
            CreatedDate = DateTime.Now;
            Status = "Chưa bắt đầu";
        }
    }
} 