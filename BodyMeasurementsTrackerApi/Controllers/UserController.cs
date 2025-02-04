using BodyMeasurementsTrackerApi.Data;
using BodyMeasurementsTrackerApi.Models;
using BodyMeasurementsTrackerApi.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BodyMeasurementsTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public UserController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(dbContext.Users.ToList());
        }

        [HttpPost("register")]
        public IActionResult SaveUser(UserDto userDto)
        {
            if (string.IsNullOrWhiteSpace(userDto.Username) || string.IsNullOrWhiteSpace(userDto.Password))
            {
                return BadRequest("Username and password are required.");
            }
            var existingUser = dbContext.Users.FirstOrDefault(u => u.Username == userDto.Username);
            if(existingUser != null)
            {
                return Conflict("User already exists");
            }
            var userEntity = new User
            {
                Username = userDto.Username,
                Password = userDto.Password,
            };

            dbContext.Users.Add(userEntity);
            dbContext.SaveChanges();
            return Ok(userEntity);
        }

        [HttpPost("login")]
        public IActionResult UserLogin(UserDto userDto)
        {
            var user = dbContext.Users.Where(u => u.Username == userDto.Username && u.Password == userDto.Password).ToList();
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
