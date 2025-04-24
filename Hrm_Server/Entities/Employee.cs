using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime? IdentityIssuedDate { get; set; }
        public string IdentityIssuedPlace { get; set; }
        public string PermanentAddress { get; set; }
        public string TemporaryAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? EthnicityId { get; set; }
        public int? ReligionId { get; set; }
        public int? EducationId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int SalaryGradeId { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? UnionJoinDate { get; set; }
        public DateTime? PartyJoinDate { get; set; }
        public DateTime? ProbationEndDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string MaritalStatus { get; set; }
        public string PolicyBeneficiary { get; set; }
        public string InsuranceNumber { get; set; }
        public string TaxCode { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public virtual Ethnicity Ethnicity { get; set; }
        public virtual Religion Religion { get; set; }
        public virtual Education Education { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual SalaryGrade SalaryGrade { get; set; }

        public virtual ICollection<FamilyMember> FamilyMembers { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<LanguageProficiency> LanguageProficiencies { get; set; }
        public virtual ICollection<WorkHistory> WorkHistories { get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }
        public virtual ICollection<Discipline> Disciplines { get; set; }
        public virtual ICollection<SalaryIncrement> SalaryIncrements { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Assignment> AssignedBy { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<Leave> Leaves { get; set; }
        public virtual ICollection<Leave> ApprovedLeaves { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public Employee()
        {
            FamilyMembers = new HashSet<FamilyMember>();
            Certificates = new HashSet<Certificate>();
            LanguageProficiencies = new HashSet<LanguageProficiency>();
            WorkHistories = new HashSet<WorkHistory>();
            Rewards = new HashSet<Reward>();
            Disciplines = new HashSet<Discipline>();
            SalaryIncrements = new HashSet<SalaryIncrement>();
            Transfers = new HashSet<Transfer>();
            Attendances = new HashSet<Attendance>();
            Assignments = new HashSet<Assignment>();
            AssignedBy = new HashSet<Assignment>();
            Salaries = new HashSet<Salary>();
            Leaves = new HashSet<Leave>();
            ApprovedLeaves = new HashSet<Leave>();
            Users = new HashSet<User>();
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
    }
} 