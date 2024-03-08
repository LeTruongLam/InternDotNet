using Exam2Demo.Domain.Entities;
using Exam2Demo.Dtos;

namespace Exam2Demo.Services
{
    public interface IApartmentService
    {
        Task<IEnumerable<Apartment>> GetAll();
        Task<Apartment> GetById(int id);
        Task AddApartment(ApartmentDto apartmentDto);
        Task UpdateApartment(int id, ApartmentDto apartmentDto);
        Task DeleteApartment(int id);
    }
}
