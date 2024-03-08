using Exam2Demo.Domain.Entities;
using Exam2Demo.Domain.Repositories;

namespace Exam2Demo.Infrastructure.Repositories
{
    public class ResidentApartmentRepository : GenericRepository<ResidentApartment>, IResidentApartmentRepository
    {
        public ResidentApartmentRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
