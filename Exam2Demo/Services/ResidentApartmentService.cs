using Exam2Demo.Domain.Entities;
using Exam2Demo.Domain.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exam2Demo.Services
{
    public class ResidentApartmentService : IResidentApartmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResidentApartmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ResidentApartment>> GetAllResidentApartments()
        {
            return await _unitOfWork.ResidentApartmentRepository.GetAllAsync();
        }

      

        public async Task AddResidentToApartment(int residentId, int apartmentId)
        {
            var residentApartment = new ResidentApartment
            {
                ResidentId = residentId,
                ApartmentId = apartmentId
            };

            _unitOfWork.ResidentApartmentRepository.Add(residentApartment);
            await _unitOfWork.CommitAsync();
        }
    }
}