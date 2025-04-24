using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Hrm_Server.DbContextHrm;
using Hrm_Server.Entities;
using Hrm_Server.Repositories.Interfaces;

namespace Hrm_Server.Repositories
{
    public class UserRepository : BaseRepository<User, int>, IUserRepository
    {
        public UserRepository(HrmDbContext context) : base(context)
        {
        }

        public User GetByUsername(string username)
        {
            return GetQueryable().FirstOrDefault(u => u.Username == username);
        }

        public bool IsUsernameExists(string username)
        {
            return Any(u => u.Username == username);
        }

        public void UpdatePassword(int userId, string newPassword)
        {
            var user = GetById(userId);
            if (user != null)
            {
                user.Password = HashPassword(newPassword);
                SaveChanges();
            }
        }

        public User Authenticate(string username, string password)
        {
            //var hashedPassword = HashPassword(password);
            return GetQueryable().FirstOrDefault(u => u.Username == username && u.Password == password && u.IsActive);
        }

        // Phương thức để hash mật khẩu
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash trả về một mảng byte
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển đổi mảng byte thành chuỗi
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Chuyển byte thành dạng hex
                }
                return builder.ToString();
            }
        }
    }
}