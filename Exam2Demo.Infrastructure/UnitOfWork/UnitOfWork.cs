using Exam2Demo.Domain.Repositories;
using Exam2Demo.Domain.UnitOfWork;
using Exam2Demo.Infrastructure.Repositories;

namespace Exam2Demo.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private IApartmentRepository _apartmentRepository;
        private IResidentRepository _residentRepository;
        private IResidentApartmentRepository _residentApartmentRepository;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IResidentRepository ResidentRepository
        {
            get { return _residentRepository ??= new ResidentRepository(_dbContext); }
        }

        public IApartmentRepository ApartmentRepository
        {
            get { return _apartmentRepository ??= new ApartmentRepository(_dbContext); }
        }

        public IResidentApartmentRepository ResidentApartmentRepository
        {
            get { return _residentApartmentRepository ??= new ResidentApartmentRepository(_dbContext); }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Rollback()
        {
            _dbContext.Dispose();
        }

        public async Task RollbackAsync()
        {
            await _dbContext.DisposeAsync();
        }
    }
}