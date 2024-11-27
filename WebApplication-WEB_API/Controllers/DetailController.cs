using Microsoft.AspNetCore.Mvc;
using WebApplication_WEB_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication_WEB_API.Controllers
{
    [ApiController] // Ensure this attribute is used for API controller behavior
    [Route("api/[controller]")]
    public class DetailController : ControllerBase
    {
        // Change details to a List<Detail> for dynamic item management
        private static List<Detail> details = new List<Detail>
        {
            new Detail {Id = 1, Name = "Nilesh", Address = "AhilyaNagar", Salary = 50000.00 },
            new Detail {Id = 2, Name = "Suyash", Address = "Nashik", Salary = 45000.00 }
        };

        // Add detail
        [HttpPost]
        [Consumes("application/xml")]  // Specify that the method consumes XML
        [Produces("application/xml")]  // Sends back XML format response
        public ActionResult AddDetail([FromBody] Detail detail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // This will return the validation errors
            }

            // Add the new detail to the list
            details.Add(detail);

            return Ok("Detail added successfully!");
        }

        // Get all details
        [HttpGet]
        public IEnumerable<Detail> GetAllDetails()
        {
            return details;
        }

        // Get detail by ID
        [HttpGet("{id}")]
        public ActionResult<Detail> GetDetailById(int id)
        {
            var detail = details.FirstOrDefault(d => d.Id == id);
            if (detail == null)
            {
                return NotFound();
            }

            return Ok(detail);
        }

        // Search by address
        [HttpGet("searchByAddress")]
        public IEnumerable<Detail> GetItemsByAddress(string address)
        {
            return details.Where(d => string.Equals(d.Address, address, StringComparison.OrdinalIgnoreCase));
        }
    }
}
