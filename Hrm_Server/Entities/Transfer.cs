using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Transfer")]
    public class Transfer
    {
        [Key]
        public int TransferId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime TransferDate { get; set; }
        public int FromDepartmentId { get; set; }
        public int ToDepartmentId { get; set; }
        public int? FromPositionId { get; set; }
        public int? ToPositionId { get; set; }
        public string Reason { get; set; }
        public string DecisionNumber { get; set; }
        public DateTime? DecisionDate { get; set; }
        public string DecisionBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Department FromDepartment { get; set; }
        public virtual Department ToDepartment { get; set; }
        public virtual Position FromPosition { get; set; }
        public virtual Position ToPosition { get; set; }

        public Transfer()
        {
            CreatedDate = DateTime.Now;
        }
    }
} 