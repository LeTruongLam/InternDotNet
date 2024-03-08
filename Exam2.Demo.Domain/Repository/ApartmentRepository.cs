using Exam2Demo.Domain.Interface;
using Exam2Demo.Models;
using Exam2Demo.Data;


namespace Exam2Demo.Domain.Repository
{
    public class ApartmentRepository : IApartment
    {
    /*    private readonly AppDbContext _dbContext;*/
        private List<Apartment> _apartments; // Giả định danh sách các apartment


        public ApartmentRepository()
        {
            _apartments = new List<Apartment>();
        }

        public List<Apartment> GetAll()
        {
            return _apartments;
        }

        public Apartment GetById(int id)
        {
            return _apartments.FirstOrDefault(apartment => apartment.Id == id);
        }

        public void Add(Apartment entity)
        {
            _apartments.Add(entity);
        }

        public void Update(Apartment entity)
        {
            var apartment = _apartments.FirstOrDefault(a => a.Id == entity.Id);
            if (apartment != null)
            {
                apartment.Name = entity.Name;
            }
        }

        public void Delete(int id)
        {
            var apartment = _apartments.FirstOrDefault(a => a.Id == id);
            if (apartment != null)
            {
                _apartments.Remove(apartment);
            }
        }
    }
}