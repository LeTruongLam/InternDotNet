using Exam2Demo.Domain.Repositories;

namespace Exam2Demo.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {

        IApartmentRepository ApartmentRepository { get; }
        IResidentRepository ResidentRepository { get; }
        IResidentApartmentRepository ResidentApartmentRepository { get; }

        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
