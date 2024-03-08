using Microsoft.AspNetCore.Mvc;
using Exam2Demo.Services;
using Exam2Demo.Domain.Entities;
using Exam2Demo.Dtos;

namespace Exam2Demo.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        public IResidentService _residentService { get; set; }
        public IApartmentService _apartmentService { get; set; }
        public IResidentApartmentService _residentApartmentService { get; set; }
        public DemoController (IResidentService residentService, IApartmentService apartmentService, IResidentApartmentService residentApartmentService)
        {
            _residentService = residentService;
            _apartmentService = apartmentService;
            _residentApartmentService = residentApartmentService;
        }
        [HttpGet("residentapartments", Name = "GetAllResidentApartments")]
        public async Task<IEnumerable<ResidentApartment>> GetAllResidentApartments()
        {
            return await _residentApartmentService.GetAllResidentApartments();
        }
        [HttpPost("residentapartments", Name = "AddResidentApartments")]
        public async Task<IActionResult> AddResidentApartments(ResidentApartmentDto residentApartmentDto)
        {
            await _residentApartmentService.AddResidentToApartment(residentApartmentDto.ResidentId, residentApartmentDto.ApartmentId);
            return Ok();
        }
        [HttpGet("residents", Name = "GetAllResidents")]
        public async Task<IEnumerable<Resident>> GetAllResidents()
        {
            return await _residentService.GetAll();
        }

        [HttpPost("residents")]
        public async Task<IActionResult> AddResident([FromBody] ResidentDto residentDto)
        {
            await _residentService.AddResident(residentDto);
            return Ok();
        }

        [HttpPut("residents/{id}")]
        public async Task<IActionResult> UpdateResident(int id, [FromBody] ResidentDto residentDto)
        {
            await _residentService.UpdateResident(id, residentDto);
            return Ok();
        }

        [HttpDelete("residents/{id}")]
        public async Task<IActionResult> DeleteResident(int id)
        {
            await _residentService.DeleteResident(id);
            return Ok();
        }

        [HttpGet("apartments", Name = "GetAllApartments")]
        public async Task<IEnumerable<Apartment>> GetAllApartments()
        {
            return await _apartmentService.GetAll();
        }

        [HttpPost("apartments")]
        public async Task<IActionResult> AddApartment([FromBody] ApartmentDto apartmentDto)
        {
            await _apartmentService.AddApartment(apartmentDto);
            return Ok();
        }

        [HttpPut("apartments/{id}")]
        public async Task<IActionResult> UpdateApartment(int id, [FromBody] ApartmentDto apartmentDto)
        {
            await _apartmentService.UpdateApartment(id, apartmentDto);
            return Ok();
        }

        [HttpDelete("apartments/{id}")]
        public async Task<IActionResult> DeleteApartment(int id)
        {
            await _apartmentService.DeleteApartment(id);
            return Ok();
        }
    }


    /*

       // GET: api/Demo/Residents
       [HttpGet("Residents")]
       public IActionResult GetResidents()
       {
           var residents = _dbContext.Residents.ToList();
           return Ok(residents);
       }

    *//*   // GET: api/Demo/Apartments
       [HttpGet("Apartments")]
       public async Task<IActionResult> GetApartments()
       {
           var apartments = await _dbContext.Apartments
               .Include(a => a.ResidentApartments)
               .ToListAsync();

           return Ok(apartments);
       }

       // POST: api/Demo/AddApartment
       [HttpPost("AddApartment")]
       public IActionResult AddApartment([FromBody] Apartment apartment)
       {
           _dbContext.Apartments.Add(apartment);
           _dbContext.SaveChanges();
           return Ok(apartment);
       }

       // PUT: api/Demo/UpdateApartment/5
       [HttpPut("UpdateApartment/{id}")]
       public IActionResult UpdateApartment(int id, [FromBody] Apartment updatedApartment)
       {
           var apartment = _dbContext.Apartments.Find(id);
           if (apartment == null)
           {
               return NotFound();
           }

           apartment.Name = updatedApartment.Name;
           // Update other properties as needed

           _dbContext.SaveChanges();
           return Ok(apartment);
       }

       // DELETE: api/Demo/DeleteApartment/5
       [HttpDelete("DeleteApartment/{id}")]
       public IActionResult DeleteApartment(int id)
       {
           var apartment = _dbContext.Apartments.Find(id);
           if (apartment == null)
           {
               return NotFound();
           }

           _dbContext.Apartments.Remove(apartment);
           _dbContext.SaveChanges();
           return Ok(apartment);
       }*//*

       // POST: api/Demo/AddResident
       [HttpPost("AddResident")]
       public IActionResult AddResident([FromBody] Resident resident)
       {
           _dbContext.Residents.Add(resident);
           _dbContext.SaveChanges();
           return Ok(resident);
       }

       // PUT: api/Demo/UpdateResident/5
       [HttpPut("UpdateResident/{id}")]
       public IActionResult UpdateResident(int id, [FromBody] Resident updatedResident)
       {
           var resident = _dbContext.Residents.Find(id);
           if (resident == null)
           {
               return NotFound();
           }

           resident.Name = updatedResident.Name;
           // Update other properties as needed

           _dbContext.SaveChanges();
           return Ok(resident);
       }

       // DELETE: api/Demo/DeleteResident/5
       [HttpDelete("DeleteResident/{id}")]
       public IActionResult DeleteResident(int id)
       {
           var resident = _dbContext.Residents.Find(id);
           if (resident == null)
           {
               return NotFound();
           }

           _dbContext.Residents.Remove(resident);
           _dbContext.SaveChanges();
           return Ok(resident);
       }
       [HttpPost("AddResidentandApartment")]
       public async Task<IActionResult> AddResidentandApartment(ResidentApartment test)
       {
           _dbContext.ResidentApartments.Add(new ResidentApartment()
           {
               ApartmentId = test.ApartmentId,
               ResidentId = test.ResidentId
           });
           await _dbContext.SaveChangesAsync();

           return Ok("Resident and Apartment added successfully");
       }

       [HttpGet("GetResidentandApartment")]
       public IActionResult GetResidentandApartment()
       {
           var residentApartments = _dbContext.ResidentApartments
               .Include(ra => ra.Resident)
               .Include(ra => ra.Apartment)
               .ToList();

           return Ok(residentApartments);
       }*/
}
