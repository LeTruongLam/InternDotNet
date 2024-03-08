using Exam2Demo.Domain.Entities;
using Exam2Demo.Dtos;

namespace Exam2Demo.Services
{
    public interface IResidentService
    {
        Task<IEnumerable<Domain.Entities.Resident>> GetAll();
        Task<Domain.Entities.Resident> GetById(int id);
        Task AddResident(ResidentDto residentDto);
        Task UpdateResident(int id, ResidentDto residentDto);
        Task DeleteResident(int id);
    }
}
