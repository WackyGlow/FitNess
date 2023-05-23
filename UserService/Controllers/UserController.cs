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
        
        /* HTTP Method: GET
         * Route: /user/{id}
         * Description: Retrieves a user by their ID.
         * Returns:
            - If the user is found, returns HTTP status code 200 (OK) with the user data.
            - If the user is not found, returns HTTP status code 404 (Not Found).
         */
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
        
        /* HTTP Method: POST
         * Route: /user
         * Description: Create a new user.
         * Parameters:
            'user' (request body): The user data to be created.
         * Returns:
            - If the user is successfully created, returns HTTP status code 200 (OK).
         */
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            // Create user logic here
            // Replace with your actual implementation
            _UserDatabase.CreateUser(user);
            return Ok();
        }

        /* HTTP Method: PUT
         * Route: /user/{id}
         * Description: Updates an existing user by their ID.
         * Parameters:
            'id' (route parameter): The ID of the user to be updated.
            'user' (request body): The updated user data.
         * Returns:
            - If the user is found and successfully updated, returns HTTP status code 200 (OK).
            - If the user is not found, returns HTTP status code 404 (Not Found).
         */
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
        /* HTTP Method: DELETE
         * Route: /user/{id}
         * Description: Deletes an existing user.
         * Parameters:
            'user' (request body): The user to be deleted.
         * Returns:
            - If the user is found and successfully deleted, returns HTTP status code 200 (OK).
            - If the user is not found, returns HTTP status code 404 (Not Found).
         */
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