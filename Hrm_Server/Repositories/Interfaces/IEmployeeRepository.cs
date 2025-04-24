using Hrm_Server.Entities;
using System;

namespace Hrm_Server.Repositories.Interfaces
{
    public interface IEmployeeRepository : IBaseRepository<Employee, int>
    {
    }
}