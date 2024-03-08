using Exam2Demo.Domain.Models.BaseEntity;
using System.Text.Json.Serialization;

namespace Exam2Demo.Models
{
    public class Apartment : BaseEntity
    {
        [JsonIgnore]
        public ICollection<ResidentApartment>? ResidentApartments { get; set; }
    }
}
