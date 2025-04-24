using System;
using Hrm_Server.Entities;
using Hrm_Server.Repositories.Interfaces;

namespace Hrm_Server.Services
{
    public interface IAuthService
    {
        User Login(string username, string password);
        bool VerifyPersonalInfo(string username, string fullName, DateTime dateOfBirth, string phoneNumber);
        bool ResetPassword(string username, string newPassword);
    }
    
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmployeeRepository _employeeRepository;
        
        public AuthService(IUserRepository userRepository, IEmployeeRepository employeeRepository)
        {
            _userRepository = userRepository;
            _employeeRepository = employeeRepository;
        }
        
        public User Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;
            
            return _userRepository.Authenticate(username, password);
        }
        
        public bool VerifyPersonalInfo(string username, string fullName, DateTime dateOfBirth, string phoneNumber)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phoneNumber))
                return false;
            
            // Lấy user theo username
            var user = _userRepository.GetByUsername(username);
            if (user == null || !user.IsActive)
                return false;
            
            // Kiểm tra user có liên kết với nhân viên không
            if (!user.EmployeeId.HasValue)
                return false;
            
            // Lấy thông tin nhân viên
            var employee = _employeeRepository.GetById(user.EmployeeId.Value);
            if (employee == null)
                return false;
            
            // Kiểm tra thông tin cá nhân
            return employee.FullName == fullName &&
                   employee.DateOfBirth.Date == dateOfBirth.Date &&
                   employee.PhoneNumber == phoneNumber;
        }
        
        public bool ResetPassword(string username, string newPassword)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword))
                return false;
            
            // Lấy user theo username
            var user = _userRepository.GetByUsername(username);
            if (user == null)
                return false;
            
            try
            {
                // Cập nhật mật khẩu mới
                _userRepository.UpdatePassword(user.UserId, newPassword);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}