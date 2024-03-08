using Exam2Demo.Domain.Entities;

namespace Exam2Demo.Services
{
    public interface IResidentApartmentService
    {
        Task<IEnumerable<ResidentApartment>> GetAllResidentApartments();
        Task AddResidentToApartment(int residentId, int apartmentId);
    }
}