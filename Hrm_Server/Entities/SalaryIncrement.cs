using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("SalaryIncrement")]
    public class SalaryIncrement
    {
        [Key]
        public int SalaryIncrementId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public int PreviousSalaryGradeId { get; set; }
        public int NewSalaryGradeId { get; set; }
        public string Reason { get; set; }
        public string DecisionNumber { get; set; }
        public DateTime? DecisionDate { get; set; }
        public string DecisionBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public int? CreatedBy { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SalaryGrade PreviousSalaryGrade { get; set; }
        public virtual SalaryGrade NewSalaryGrade { get; set; }

        public SalaryIncrement()
        {
            CreatedDate = DateTime.Now;
        }
    }
} 