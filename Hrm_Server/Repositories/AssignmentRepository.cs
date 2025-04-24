using Hrm_Server.DbContextHrm;
using Hrm_Server.Entities;
using Hrm_Server.Repositories.Interfaces;

namespace Hrm_Server.Repositories
{
    public class AssignmentRepository : BaseRepository<Assignment, int>, IAssignmentRepository
    {
        public AssignmentRepository(HrmDbContext context) : base(context)
        {
        }
    }
}