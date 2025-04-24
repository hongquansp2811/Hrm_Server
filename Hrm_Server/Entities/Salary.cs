using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Salary")]
    public class Salary
    {
        [Key]
        public int SalaryId { get; set; }

        public int EmployeeId { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }
        public decimal WorkingDays { get; set; }
        public int SalaryGradeId { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Coefficient { get; set; }
        public decimal PositionAllowance { get; set; }
        public decimal OtherAllowance { get; set; }
        public decimal Bonus { get; set; }
        public decimal Deduction { get; set; }
        public decimal SocialInsurance { get; set; }
        public decimal HealthInsurance { get; set; }
        public decimal UnemploymentInsurance { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal NetSalary { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SalaryGrade SalaryGrade { get; set; }
        public Salary()
        {
            CreatedDate = DateTime.Now;
            PositionAllowance = 0;
            OtherAllowance = 0;
            Bonus = 0;
            Deduction = 0;
            SocialInsurance = 0;
            HealthInsurance = 0;
            UnemploymentInsurance = 0;
            IncomeTax = 0;
            Status = "Chưa thanh toán";
        }
    }
} 