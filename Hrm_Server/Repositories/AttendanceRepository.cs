using Hrm_Server.DbContextHrm;
using Hrm_Server.Entities;
using Hrm_Server.Repositories.Interfaces;

namespace Hrm_Server.Repositories
{
    public class AttendanceRepository : BaseRepository<Attendance, int>, IAttendanceRepository
    {
        public AttendanceRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class CertificateRepository : BaseRepository<Certificate, int>, ICertificateRepository
    {
        public CertificateRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class DisciplineRepository : BaseRepository<Discipline, int>, IDisciplineRepository
    {
        public DisciplineRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class EmployeeTypeRepository : BaseRepository<EmployeeType, int>, IEmployeeTypeRepository
    {
        public EmployeeTypeRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class EthnicityRepository : BaseRepository<Ethnicity, int>, IEthnicityRepository
    {
        public EthnicityRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class FamilyMemberRepository : BaseRepository<FamilyMember, int>, IFamilyMemberRepository
    {
        public FamilyMemberRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class LanguageProficiencyRepository : BaseRepository<LanguageProficiency, int>,
        ILanguageProficiencyRepository
    {
        public LanguageProficiencyRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class LeaveRepository : BaseRepository<Leave, int>, ILeaveRepository
    {
        public LeaveRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class EducationRepository : BaseRepository<Education, int>, IEducationRepository
    {
        public EducationRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class PositionRepository : BaseRepository<Position, int>, IPositionRepository
    {
        public PositionRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class ReligionRepository : BaseRepository<Religion, int>, IReligionRepository
    {
        public ReligionRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class RewardRepository : BaseRepository<Reward, int>, IRewardRepository
    {
        public RewardRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class SalaryRepository : BaseRepository<Salary, int>, ISalaryRepository
    {
        public SalaryRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class SalaryGradeRepository : BaseRepository<SalaryGrade, int>, ISalaryGradeRepository
    {
        public SalaryGradeRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class SalaryIncrementRepository : BaseRepository<SalaryIncrement, int>, ISalaryIncrementRepository
    {
        public SalaryIncrementRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class TransferRepository : BaseRepository<Transfer, int>, ITransferRepository
    {
        public TransferRepository(HrmDbContext context) : base(context)
        {
        }
    }

    public class WorkHistoryRepository : BaseRepository<WorkHistory, int>, IWorkHistoryRepository
    {
        public WorkHistoryRepository(HrmDbContext context) : base(context)
        {
        }
    }
}