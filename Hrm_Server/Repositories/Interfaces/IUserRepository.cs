using Hrm_Server.Entities;

namespace Hrm_Server.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User, int>
    {
        // Lấy user theo username
        User GetByUsername(string username);
        
        // Kiểm tra username đã tồn tại hay chưa
        bool IsUsernameExists(string username);
        
        // Cập nhật mật khẩu cho user
        void UpdatePassword(int userId, string newPassword);
        
        // Xác thực thông tin user
        User Authenticate(string username, string password);
    }
}