using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Hrm_Server.DbContextHrm;
using Hrm_Server.Entities;
using Hrm_Server.Repositories.Interfaces;

namespace Hrm_Server.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(HrmDbContext context) : base(context)
        {
        }

        public Employee GetByFullName(string fullName)
        {
            return GetQueryable().FirstOrDefault(e => e.FullName == fullName && e.IsActive);
        }

        public Employee FindByPersonalInfo(string fullName, DateTime dateOfBirth, string phoneNumber)
        {
            return GetQueryable().FirstOrDefault(e => 
                e.FullName == fullName && 
                e.DateOfBirth == dateOfBirth &&
                e.PhoneNumber == phoneNumber &&
                e.IsActive);
        }

        public Employee GetByEmployeeCode(string employeeCode)
        {
            return GetQueryable().FirstOrDefault(e => e.EmployeeCode == employeeCode && e.IsActive);
        }

        public IEnumerable<Employee> GetByDepartment(int departmentId)
        {
            return GetQueryable().Where(e => e.DepartmentId == departmentId && e.IsActive);
        }

        public IEnumerable<Employee> GetEmployeesForSalaryIncrement(int months)
        {
            // Lấy danh sách nhân viên đến hạn tăng lương (3 năm một lần)
            var threeYearsAgo = DateTime.Now.AddYears(-3).AddMonths(months);
            
            // Lấy các nhân viên có lần tăng lương gần nhất cách đây 3 năm
            return DbSet.Where(e => e.IsActive && 
                     (!e.SalaryIncrements.Any() && e.JoinDate <= threeYearsAgo) || // Chưa từng được tăng lương và đã làm việc ít nhất 3 năm
                     (e.SalaryIncrements.Any() && e.SalaryIncrements.OrderByDescending(s => s.FromDate).FirstOrDefault().FromDate <= threeYearsAgo) // Lần tăng lương gần nhất cách đây 3 năm
                 ).ToList();
        }

        public IEnumerable<Employee> GetEmployeesForRetirement(int months)
        {
            var today = DateTime.Now;
            var retirementAgeForMale = 60;
            var retirementAgeForFemale = 55;
            
            return DbSet.Where(e => e.IsActive &&
                      ((e.Gender == "Nam" && today.AddMonths(months).Year - e.DateOfBirth.Year >= retirementAgeForMale) ||
                       (e.Gender == "Nữ" && today.AddMonths(months).Year - e.DateOfBirth.Year >= retirementAgeForFemale))
                  ).ToList();
        }

        public IEnumerable<Employee> GetEmployeesWithBirthdayInMonth(int month)
        {
            return DbSet.Where(e => e.IsActive && e.DateOfBirth.Month == month).ToList();
        }
    }
}