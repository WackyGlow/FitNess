//using Microsoft.AspNetCore.Mvc;
//using Moq;
//using UserService.Controllers;
//using UserService.Database;
//using UserService.Infrastructure;
//using UserService.Models;
//using Xunit;

//namespace UserService.Tests
//{
//    public class UserControllerTests
//    {
//        private readonly UserController _controller;
//        private readonly Mock<UserDatabase> _userDatabaseMock;
//        private readonly Mock<IUserMessagePublisher> _userMessagePublisherMock;

//        public UserControllerTests()
//        {
//            _userDatabaseMock = new Mock<UserDatabase>();
//            _userMessagePublisherMock = new Mock<IUserMessagePublisher>();

//            var user1 = new User { Id = 1, FirstName = "John", LastName = "Doe" };
//            var user2 = new User { Id = 2, FirstName = "Jane", LastName = "Smith" };
//            var user3 = new User { Id = 3, FirstName = "Alice", LastName = "Johnson" };

//            _userDatabaseMock.Setup(db => db.GetUserById(1)).Returns(user1);
//            _userDatabaseMock.Setup(db => db.GetUserById(2)).Returns(user2);
//            _userDatabaseMock.Setup(db => db.GetUserById(3)).Returns(user3);

//            _controller = new UserController(_userMessagePublisherMock.Object);
//            _controller._UserDatabase = _userDatabaseMock.Object;
//        }

//        [Fact]
//        public void GetUser_ExistingUser_ReturnsOkWithUserData()
//        {
//            // Arrange
//            int userId = 1;

//            // Act
//            IActionResult result = _controller.GetUser(userId);

//            // Assert
//            OkObjectResult okResult = Assert.IsType<OkObjectResult>(result);
//            User returnedUser = Assert.IsType<User>(okResult.Value);
//            Assert.Equal("John", returnedUser.FirstName);
//            Assert.Equal("Doe", returnedUser.LastName);
//        }

//        [Fact]
//        public void GetUser_NonExistingUser_ReturnsNotFound()
//        {
//            // Arrange
//            int userId = 4;

//            // Act
//            IActionResult result = _controller.GetUser(userId);

//            // Assert
//            Assert.IsType<NotFoundResult>(result);
//        }

//        [Fact]
//        public void CreateUser_ValidUser_ReturnsOk()
//        {
//            // Arrange
//            User user = new User { FirstName = "Alex", LastName = "Williams" };

//            // Act
//            IActionResult result = _controller.CreateUser(user);

//            // Assert
//            Assert.IsType<OkResult>(result);
//            _userDatabaseMock.Verify(db => db.CreateUser(user), Times.Once);
//            _userMessagePublisherMock.Verify(p => p.PublishCalorieIntakeCreatedMessage(user), Times.Once);
//        }

//        [Fact]
//        public void UpdateUser_ExistingUser_ReturnsOk()
//        {
//            // Arrange
//            int userId = 2;
//            User updatedUser = new User { Id = userId, FirstName = "Jane", LastName = "Johnson" };

//            // Act
//            IActionResult result = _controller.UpdateUser(userId, updatedUser);

//            // Assert
//            Assert.IsType<OkResult>(result);
//            _userDatabaseMock.Verify(db => db.UpdateUser(userId, updatedUser), Times.Once);
//        }

//        [Fact]
//        public void UpdateUser_NonExistingUser_ReturnsNotFound()
//        {
//            // Arrange
//            int userId = 4;
//            User updatedUser = new User { Id = userId, FirstName = "Alice", LastName = "Smith" };

//            // Act
//            IActionResult result = _controller.UpdateUser(userId, updatedUser);

//            // Assert
//            Assert.IsType<NotFoundResult>(result);
//        }

//        [Fact]
//        public void DeleteUser_ExistingUser_ReturnsOk()
//        {
//            // Arrange
//            int userId = 3;
//            var user = new User { Id = userId };

//            // Act
//            IActionResult result = _controller.DeleteUser(user);

//            // Assert
//            Assert.IsType<OkResult>(result);
//            _userDatabaseMock.Verify(db => db.DeleteUser(user), Times.Once);
//        }

//        [Fact]
//        public void DeleteUser_NonExistingUser_ReturnsNotFound()
//        {
//            // Arrange
//            int userId = 4;
//            var user = new User { Id = userId };

//            // Act
//            IActionResult result = _controller.DeleteUser(user);

//            // Assert
//            Assert.IsType<NotFoundResult>(result);
//        }
//    }
//}