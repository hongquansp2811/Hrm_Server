using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Reward")]
    public class Reward
    {
        [Key]
        public int RewardId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime RewardDate { get; set; }
        public string RewardType { get; set; }
        public decimal? Amount { get; set; }
        public string Reason { get; set; }
        public string DecisionNumber { get; set; }
        public DateTime? DecisionDate { get; set; }
        public string DecisionBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public virtual Employee Employee { get; set; }
        public Reward()
        {
            CreatedDate = DateTime.Now;
            Amount = 0;
        }
    }
} 