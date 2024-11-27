//using System.Net;
//using Microsoft.AspNetCore.Mvc;
//using WebApplication_WEB_API.Models;

//namespace WebApplication_WEB_API.Controllers
//{
//    [ApiController] // Ensure this attribute is used for API controller behavior
//    [Route("api/[controller]")]
//    public class DetailController : ControllerBase
//    {

//        Detail[] details = new Detail[]
//        {
//            new Detail {Id=1, Name ="Nilesh", Address="AhilyaNagar", Salary = 50000.00 },
//            new Detail {Id=2, Name = "Suyash", Address ="Nashik" , Salary = 45000.00 }
//        };

//        // Add detail
//        [HttpPost]
//        [Consumes("application/xml")]  // Specify that the method consumes XML
//        public ActionResult AddDetail([FromBody] Detail detail)
//        {
//            if (detail == null)
//            {
//                return BadRequest("Invalid data.");
//            }

//            // Add the new detail to the list
//            details.Add(detail);

//            return Ok("Detail added successfully!");
//        }

//        // Get all details
//        [HttpGet]
//        public IEnumerable<Detail> GetAllDetails()
//        {
//            return details;
//        }

//        // Get detail by ID
//        [HttpGet("{id}")]
//        public ActionResult<Detail> GetDetailById(int id)
//        {
//            var detail = details.FirstOrDefault((I) => I.Id == id);
//            if (detail == null)
//            {
//                return NotFound();
//            }

//            return Ok(detail);
//        }


//        // Search by address (extra method, not used in your JavaScript but can be extended)
//        [HttpGet("searchByAddress")]
//        public IEnumerable<Detail> GetItemsByAddress(string address)
//        {
//            return details.Where(d => string.Equals(d.Address, address, StringComparison.OrdinalIgnoreCase));
//        }

//    }
//}
