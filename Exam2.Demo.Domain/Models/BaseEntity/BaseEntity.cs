using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Exam2Demo.Domain.Models.BaseEntity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        // Relationship: Many to many
      
    }
}
