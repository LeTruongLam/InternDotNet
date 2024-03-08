using Exam2Demo.Domain.Entities;
using Exam2Demo.Domain.UnitOfWork;
using Exam2Demo.Dtos;

namespace Exam2Demo.Services
{
    public class ApartmentService : IApartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ApartmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Apartment>> GetAll()
        {
            return await _unitOfWork.ApartmentRepository.GetAllAsync();
        }
        public async Task<Apartment> GetById(int id)
        {
            var apartments = await GetAll();
            return apartments.FirstOrDefault(x => x.Id == id);
        }
        public async Task AddApartment(ApartmentDto apartmentDto)
        {
            var apartment = new Apartment
            {
                Name = apartmentDto.Name,
            };

            _unitOfWork.ApartmentRepository.Add(apartment);
            await _unitOfWork.CommitAsync();
        }
        public async Task UpdateApartment(int id, ApartmentDto apartmentDto)
        {
            var apartment = await GetById(id);

            if (apartment == null)
            {
                throw new ArgumentException("resident not found");
            }

            apartment.Name = apartmentDto.Name;
            await _unitOfWork.CommitAsync();
        }
        public async Task DeleteApartment(int id)
        {
            var apartment = await GetById(id);

            if (apartment == null)
            {
                throw new ArgumentException("resident not found");
            }

            _unitOfWork.ApartmentRepository.Remove(apartment);
            await _unitOfWork.CommitAsync();
        }


    }
}
