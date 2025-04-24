using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("WorkHistory")]
    public class WorkHistory
    {
        [Key]
        public int WorkHistoryId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public WorkHistory()
        {
            CreatedDate = DateTime.Now;
        }
    }
} 