using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Leave")]
    public class Leave
    {
        [Key]
        public int LeaveId { get; set; }

        public int EmployeeId { get; set; }
        public string LeaveType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal TotalDays { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee ApprovedByEmployee { get; set; }

        public Leave()
        {
            CreatedDate = DateTime.Now;
            Status = "Chờ duyệt";
        }
    }
} 