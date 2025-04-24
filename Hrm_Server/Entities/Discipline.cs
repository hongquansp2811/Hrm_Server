using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Discipline")]
    public class Discipline
    {
        [Key]
        public int DisciplineId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DisciplineDate { get; set; }
        public string DisciplineType { get; set; }
        public decimal? Amount { get; set; }
        public string Reason { get; set; }
        public string DecisionNumber { get; set; }
        public DateTime? DecisionDate { get; set; }
        public string DecisionBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public virtual Employee Employee { get; set; }
        public Discipline()
        {
            CreatedDate = DateTime.Now;
            Amount = 0;
        }
    }
} 