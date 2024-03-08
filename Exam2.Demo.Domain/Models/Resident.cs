using Exam2Demo.Domain.Models.BaseEntity;
using System.Text.Json.Serialization;

namespace Exam2Demo.Models
{
    public class Resident : BaseEntity
    {

        [JsonIgnore]
        public ICollection<ResidentApartment>? ResidentApartments { get; set; }
    }
}
