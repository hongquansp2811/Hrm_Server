using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("SalaryGrade")]
    public class SalaryGrade
    {
        [Key]
        public int SalaryGradeId { get; set; }
        public string GradeName { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Coefficient { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<SalaryIncrement> PreviousSalaryGrades { get; set; }
        public virtual ICollection<SalaryIncrement> NewSalaryGrades { get; set; }

        public SalaryGrade()
        {
            Employees = new HashSet<Employee>();
            Salaries = new HashSet<Salary>();
            PreviousSalaryGrades = new HashSet<SalaryIncrement>();
            NewSalaryGrades = new HashSet<SalaryIncrement>();
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
    }
} 