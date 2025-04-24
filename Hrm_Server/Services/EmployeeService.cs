using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Hrm_Server.Entities;
using Hrm_Server.Repositories.Interfaces;

namespace Hrm_Server.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> SearchEmployees(string searchTerm);
        IEnumerable<Employee> GetEmployeesByDepartment(int departmentId);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        List<Department> GetAllDepartments();
        List<Position> GetAllPositions();
        List<SalaryGrade> GetAllSalaryGrades();
        List<EmployeeType> GetAllEmployeeTypes();
    }
    
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IPositionRepository _positionRepository;
        private readonly ISalaryGradeRepository _salaryGradeRepository;
        private readonly IEmployeeTypeRepository _employeeTypeRepository;
        
        public EmployeeService(
            IEmployeeRepository employeeRepository,
            IDepartmentRepository departmentRepository,
            IPositionRepository positionRepository,
            ISalaryGradeRepository salaryGradeRepository,
            IEmployeeTypeRepository employeeTypeRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
            _positionRepository = positionRepository;
            _salaryGradeRepository = salaryGradeRepository;
            _employeeTypeRepository = employeeTypeRepository;
        }
        
        public IEnumerable<Employee> GetAllEmployees()
        {
            // Sử dụng GetQueryable để lấy tất cả nhân viên cùng với các thông tin liên quan
            return _employeeRepository.GetQueryable()
                .Include(e => e.Department)
                .Include(e => e.Position)
                .Include(e => e.EmployeeType)
                .Where(e => e.IsActive)
                .OrderBy(e => e.EmployeeCode)
                .ToList();
        }
        
        public Employee GetEmployeeById(int id)
        {
            // Sử dụng GetQueryable để lấy thông tin chi tiết của một nhân viên
            return _employeeRepository.GetQueryable()
                .Include(e => e.Department)
                .Include(e => e.Position)
                .Include(e => e.EmployeeType)
                .Include(e => e.SalaryGrade)
                .Include(e => e.Ethnicity)
                .Include(e => e.Religion)
                .Include(e => e.Education)
                .FirstOrDefault(e => e.EmployeeId == id && e.IsActive);
        }
        
        public IEnumerable<Employee> SearchEmployees(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return GetAllEmployees();
                
            searchTerm = searchTerm.ToLower();
            
            // Sử dụng GetQueryable để tìm kiếm nhân viên
            return _employeeRepository.GetQueryable()
                .Include(e => e.Department)
                .Include(e => e.Position)
                .Where(e => e.IsActive && 
                    (e.EmployeeCode.ToLower().Contains(searchTerm) ||
                     e.FullName.ToLower().Contains(searchTerm) ||
                     e.PhoneNumber.Contains(searchTerm) ||
                     e.Email.ToLower().Contains(searchTerm) ||
                     e.Department.DepartmentName.ToLower().Contains(searchTerm) ||
                     e.Position.PositionName.ToLower().Contains(searchTerm)))
                .OrderBy(e => e.EmployeeCode)
                .ToList();
        }
        
        public IEnumerable<Employee> GetEmployeesByDepartment(int departmentId)
        {
            // Sử dụng GetQueryable để lấy nhân viên theo phòng ban
            return _employeeRepository.GetQueryable()
                .Include(e => e.Position)
                .Where(e => e.DepartmentId == departmentId && e.IsActive)
                .OrderBy(e => e.EmployeeCode)
                .ToList();
        }
        
        public void AddEmployee(Employee employee)
        {
            // Thiết lập các giá trị mặc định
            employee.CreatedDate = DateTime.Now;
            employee.IsActive = true;
            employee.FullName = $"{employee.LastName} {employee.FirstName}";
            
            // Thêm nhân viên
            _employeeRepository.Add(employee);
            _employeeRepository.SaveChanges();
        }
        
        public void UpdateEmployee(Employee employee)
        {
            // Lấy thông tin nhân viên hiện tại từ database
            var existingEmployee = _employeeRepository.GetById(employee.EmployeeId);
            
            if (existingEmployee != null)
            {
                // Cập nhật thông tin
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.FullName = $"{employee.LastName} {employee.FirstName}";
                existingEmployee.DateOfBirth = employee.DateOfBirth;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.IdentityNumber = employee.IdentityNumber;
                existingEmployee.IdentityIssuedDate = employee.IdentityIssuedDate;
                existingEmployee.IdentityIssuedPlace = employee.IdentityIssuedPlace;
                existingEmployee.PermanentAddress = employee.PermanentAddress;
                existingEmployee.TemporaryAddress = employee.TemporaryAddress;
                existingEmployee.PhoneNumber = employee.PhoneNumber;
                existingEmployee.Email = employee.Email;
                existingEmployee.EthnicityId = employee.EthnicityId;
                existingEmployee.ReligionId = employee.ReligionId;
                existingEmployee.EducationId = employee.EducationId;
                existingEmployee.EmployeeTypeId = employee.EmployeeTypeId;
                existingEmployee.DepartmentId = employee.DepartmentId;
                existingEmployee.PositionId = employee.PositionId;
                existingEmployee.SalaryGradeId = employee.SalaryGradeId;
                existingEmployee.JoinDate = employee.JoinDate;
                existingEmployee.UnionJoinDate = employee.UnionJoinDate;
                existingEmployee.PartyJoinDate = employee.PartyJoinDate;
                existingEmployee.ProbationEndDate = employee.ProbationEndDate;
                existingEmployee.ContractEndDate = employee.ContractEndDate;
                existingEmployee.MaritalStatus = employee.MaritalStatus;
                existingEmployee.PolicyBeneficiary = employee.PolicyBeneficiary;
                existingEmployee.InsuranceNumber = employee.InsuranceNumber;
                existingEmployee.TaxCode = employee.TaxCode;
                existingEmployee.BankAccount = employee.BankAccount;
                existingEmployee.BankName = employee.BankName;
                existingEmployee.ModifiedDate = DateTime.Now;
                
                _employeeRepository.SaveChanges();
            }
        }
        
        public void DeleteEmployee(int id)
        {
            var employee = _employeeRepository.GetById(id);
            
            if (employee != null)
            {
                // Đánh dấu là không hoạt động thay vì xóa hoàn toàn
                employee.IsActive = false;
                employee.ModifiedDate = DateTime.Now;
                
                _employeeRepository.SaveChanges();
            }
        }
        
        public List<Department> GetAllDepartments()
        {
            return _departmentRepository.GetQueryable().ToList();
        }
        
        public List<Position> GetAllPositions()
        {
            return _positionRepository.GetQueryable().ToList();
        }
        
        public List<SalaryGrade> GetAllSalaryGrades()
        {
            return _salaryGradeRepository.GetQueryable().ToList();
        }
        
        public List<EmployeeType> GetAllEmployeeTypes()
        {
            return _employeeTypeRepository.GetQueryable().ToList();
        }
    }
}