using Exam2Demo.Domain.Entities;
using Exam2Demo.Domain.UnitOfWork;
using Exam2Demo.Dtos;

namespace Exam2Demo.Services
{
    public class ResidentService : IResidentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ResidentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Resident>> GetAll()
        {
            return await _unitOfWork.ResidentRepository.GetAllAsync();
        }
        public async Task<Resident> GetById(int id)
        {
            var residents = await GetAll();
            return residents.FirstOrDefault(x => x.Id == id);
        }
        public async Task AddResident(ResidentDto residentDto)
        {
            var resident = new Resident
            {
                Name = residentDto.Name,
            };

            _unitOfWork.ResidentRepository.Add(resident);
            await _unitOfWork.CommitAsync();
        }
        public async Task UpdateResident(int id, ResidentDto residentDto)
        {
            var resident = await GetById(id);

            if (resident == null)
            {
                throw new ArgumentException("resident not found");
            }

            resident.Name = residentDto.Name;
            await _unitOfWork.CommitAsync();
        }
        public async Task DeleteResident(int id)
        {
            var resident = await GetById(id);

            if (resident == null)
            {
                throw new ArgumentException("resident not found");
            }

            _unitOfWork.ResidentRepository.Remove(resident);
            await _unitOfWork.CommitAsync();
        }


    }
}
