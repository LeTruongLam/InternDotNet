﻿using System.Text.Json.Serialization;

namespace Exam2Demo.Domain.Entities
{
    public class ResidentApartment
    {
        public int ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }
        public int ResidentId { get; set; }

        public Resident? Resident { get; set; }
    }
}
