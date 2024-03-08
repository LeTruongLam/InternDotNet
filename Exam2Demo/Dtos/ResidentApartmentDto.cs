namespace Exam2Demo.Dtos
{
    public class ResidentApartmentDto
    {
        public int ApartmentId { get; set; }
        public ApartmentDto? Apartment { get; set; }
        public int ResidentId { get; set; }

        public ResidentDto? Resident { get; set; }
    }
}
