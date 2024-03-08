using Exam2Demo.Domain.Entities;
using Exam2Demo.Domain.Repositories;

namespace Exam2Demo.Infrastructure.Repositories
{
    public class ResidentRepository : GenericRepository<Resident>, IResidentRepository
    {
        public ResidentRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
