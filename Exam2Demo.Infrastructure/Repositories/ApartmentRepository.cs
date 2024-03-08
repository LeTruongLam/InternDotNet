using Exam2Demo.Domain.Entities;
using Exam2Demo.Domain.Repositories;

namespace Exam2Demo.Infrastructure.Repositories
{
    public class ApartmentRepository : GenericRepository<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
