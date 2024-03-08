namespace Exam2Demo.Domain.Entities
{
    public class Apartment : BaseEntity
    {
        // Relationship: Many to many
        public ICollection<ResidentApartment>? ResidentApartments { get; set; }
    }
}