using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrderingApp.DataProvider;
using OnlineFoodOrderingApp.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineFoodOrderingApp.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class HotelManagementController : ControllerBase
    {
        private InMemoryDatabase _database;
        public HotelManagementController()
        {
            _database = new InMemoryDatabase();
        }
        // GET: api/<HotelManagementController>
        [HttpGet("/HotelDetails")]
        public IEnumerable<Hotel> GetHotelDetails()
        {
            return _database.GetHotelDetails();
        }

        [HttpGet("/HotelDetails/{hotelName}")]
        public IEnumerable<MenuItem> GetHotelMenu(string hotelName)
        {
            return _database.GetHotelMenu(hotelName);
        }

        //POST api/<HotelManagementController>
        [HttpPost("/Order")]
        public int OrderFood(User user)
        {
            return 1;
        }

        //// GET api/<HotelManagementController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<HotelManagementController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<HotelManagementController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<HotelManagementController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
