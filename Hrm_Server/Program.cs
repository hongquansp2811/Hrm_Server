using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hrm_Server.DbContextHrm;
using Hrm_Server.UI.AuthForm;
using Hrm_Server.UI;

namespace Hrm_Server
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Tạo một đối tượng DbContext để kiểm tra kết nối database
            try
            {
                using (var dbContext = new HrmDbContext())
                {
                    // Thử kết nối đến database
                    dbContext.Database.Connection.Open();
                    Console.WriteLine("Kết nối đến database thành công!");
                    dbContext.Database.Connection.Close();
                }
                
                // Nếu kết nối thành công, mở form đăng nhập
                Application.Run(new Login());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối đến database: {ex.Message}\n\nVui lòng kiểm tra lại kết nối và khởi động lại ứng dụng.", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
