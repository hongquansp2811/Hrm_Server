using System.Data.Entity;
using Hrm_Server.Entities;

namespace Hrm_Server.DbContextHrm
{
    public class HrmDbContext : DbContext
    {
        public HrmDbContext() : base("name=HrmDbConnection")
        {
            // Disable lazy loading by default
            this.Configuration.LazyLoadingEnabled = false;
            
            // Enable proxy creation
            this.Configuration.ProxyCreationEnabled = true;
        }

        // DbSets cho các entity
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Ethnicity> Ethnicities { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<SalaryGrade> SalaryGrades { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FamilyMember> FamilyMembers { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<LanguageProficiency> LanguageProficiencies { get; set; }
        public virtual DbSet<WorkHistory> WorkHistories { get; set; }
        public virtual DbSet<Reward> Rewards { get; set; }
        public virtual DbSet<Discipline> Disciplines { get; set; }
        public virtual DbSet<SalaryIncrement> SalaryIncrements { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Leave> Leaves { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Cấu hình Entity Framework
            
            // Cấu hình khoá ngoại cho Employee
            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Ethnicity)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.EthnicityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Religion)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.ReligionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Education)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.EducationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasRequired(e => e.EmployeeType)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.EmployeeTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasRequired(e => e.Department)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasRequired(e => e.Position)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.PositionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasRequired(e => e.SalaryGrade)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.SalaryGradeId)
                .WillCascadeOnDelete(false);

            // Cấu hình khoá ngoại cho Assignment
            modelBuilder.Entity<Assignment>()
                .HasRequired(a => a.Employee)
                .WithMany(e => e.Assignments)
                .HasForeignKey(a => a.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assignment>()
                .HasOptional(a => a.AssignedByEmployee)
                .WithMany(e => e.AssignedBy)
                .HasForeignKey(a => a.AssignedBy)
                .WillCascadeOnDelete(false);

            // Cấu hình khoá ngoại cho Leave
            modelBuilder.Entity<Leave>()
                .HasRequired(l => l.Employee)
                .WithMany(e => e.Leaves)
                .HasForeignKey(l => l.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leave>()
                .HasOptional(l => l.ApprovedByEmployee)
                .WithMany(e => e.ApprovedLeaves)
                .HasForeignKey(l => l.ApprovedBy)
                .WillCascadeOnDelete(false);

            // Cấu hình khoá ngoại cho SalaryIncrement
            modelBuilder.Entity<SalaryIncrement>()
                .HasRequired(s => s.PreviousSalaryGrade)
                .WithMany(sg => sg.PreviousSalaryGrades)
                .HasForeignKey(s => s.PreviousSalaryGradeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalaryIncrement>()
                .HasRequired(s => s.NewSalaryGrade)
                .WithMany(sg => sg.NewSalaryGrades)
                .HasForeignKey(s => s.NewSalaryGradeId)
                .WillCascadeOnDelete(false);

            // Cấu hình khoá ngoại cho Transfer
            modelBuilder.Entity<Transfer>()
                .HasRequired(t => t.FromDepartment)
                .WithMany(d => d.FromDepartments)
                .HasForeignKey(t => t.FromDepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transfer>()
                .HasRequired(t => t.ToDepartment)
                .WithMany(d => d.ToDepartments)
                .HasForeignKey(t => t.ToDepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transfer>()
                .HasOptional(t => t.FromPosition)
                .WithMany(p => p.FromPositions)
                .HasForeignKey(t => t.FromPositionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transfer>()
                .HasOptional(t => t.ToPosition)
                .WithMany(p => p.ToPositions)
                .HasForeignKey(t => t.ToPositionId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}