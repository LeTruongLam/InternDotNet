namespace Exam2Demo.Domain.Entities
{
    public class Resident : BaseEntity
    {
        // Relationship: Many to many
        public ICollection<ResidentApartment>? ResidentApartments { get; set; }
    }
}
