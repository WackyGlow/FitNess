using Microsoft.AspNetCore.Mvc;
using UserService.Database;
using UserService.Models;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public UserDatabase _UserDatabase = new UserDatabase();
        
        // GET: /user/{id}
        [HttpGet("{id}")]
        public IActionResult GetUser(string id)
        {
            // Retrieve user logic here
            // Replace with your actual implementation
            var user = _UserDatabase.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST: /user
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            // Create user logic here
            // Replace with your actual implementation
            _UserDatabase.CreateUser(user);
            return Ok();
        }

        // PUT: /user/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(string id, [FromBody] User user)
        {
            // Update user logic here
            // Replace with your actual implementation
            var existingUser = _UserDatabase.GetUserById(id);
            if (existingUser == null)
            {
                return NotFound();
            }
        
            // Update relevant properties
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.Age = user.Age;
            existingUser.Sex = user.Sex;
            existingUser.Weight = user.Weight;
            existingUser.DesiredWeight = user.DesiredWeight;

            _UserDatabase.UpdateUser(id, existingUser); // Save the updated user
            return Ok();
        }
        // DELETE: /user/{id}
        [HttpDelete]
        public IActionResult DeleteUser(User user)
        {
            // Delete user logic here
            // Replace with your actual implementation
            var existingUser = user;
            if (existingUser == null)
            {
                return NotFound();
            }
            _UserDatabase.DeleteUser(user);
            return Ok();
        }

        // Placeholder methods, replace with actual implementation
        
    }
}