using Hrm_Server.DbContextHrm;
using Hrm_Server.Entities;
using Hrm_Server.Repositories.Interfaces;

namespace Hrm_Server.Repositories
{
    public class DepartmentRepository : BaseRepository<Department, int>, IDepartmentRepository
    {
        public DepartmentRepository(HrmDbContext context) : base(context)
        {
        }
    }
}