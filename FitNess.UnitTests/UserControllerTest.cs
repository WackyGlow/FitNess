using Microsoft.AspNetCore.Mvc;
using Moq;
using UserService.Controllers;
using UserService.Database;
using UserService.Infrastructure;
using UserService.Models;
using Xunit;

namespace UserService.Tests.Controllers
{
    public class UserControllerTests
    {
        private readonly UserController _controller;
        private readonly Mock<IUserMessagePublisher> _userMessagePublisherMock;

        public UserControllerTests()
        {
            _userMessagePublisherMock = new Mock<IUserMessagePublisher>();
            _controller = new UserController(_userMessagePublisherMock.Object);
        }

        [Fact]
        public void GetUser_ExistingUserId_ReturnsOkWithUserData()
        {
            // Arrange
            var userId = 1;
            var expectedUser = new User { Id = userId, FirstName = "John", LastName = "Doe" };
            var userDatabaseMock = new Mock<UserDatabase>();
            userDatabaseMock.Setup(db => db.GetUserById(userId)).Returns(expectedUser);
            _controller._UserDatabase = userDatabaseMock.Object;

            // Act
            var result = _controller.GetUser(userId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var user = Assert.IsType<User>(okResult.Value);
            Assert.Equal(expectedUser.Id, user.Id);
            Assert.Equal(expectedUser.FirstName, user.FirstName);
            Assert.Equal(expectedUser.LastName, user.LastName);
        }

        [Fact]
        public void GetUser_NonExistingUserId_ReturnsNotFound()
        {
            // Arrange
            var userId = 1;
            var userDatabaseMock = new Mock<UserDatabase>();
            userDatabaseMock.Setup(db => db.GetUserById(userId)).Returns((User)null);
            _controller._UserDatabase = userDatabaseMock.Object;

            // Act
            var result = _controller.GetUser(userId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void CreateUser_ValidUser_ReturnsOk()
        {
            // Arrange
            var user = new User { Id = 1, FirstName = "John", LastName = "Doe" };

            // Act
            var result = _controller.CreateUser(user);

            // Assert
            var okResult = Assert.IsType<OkResult>(result);
            _userMessagePublisherMock.Verify(publisher => publisher.PublishCalorieIntakeCreatedMessage(user), Times.Once);
        }

        [Fact]
        public void UpdateUser_ExistingUserId_ReturnsOk()
        {
            // Arrange
            var userId = 1;
            var existingUser = new User { Id = userId, FirstName = "John", LastName = "Doe" };
            var updatedUser = new User { Id = userId, FirstName = "Jane", LastName = "Smith" };
            var userDatabaseMock = new Mock<UserDatabase>();
            userDatabaseMock.Setup(db => db.GetUserById(userId)).Returns(existingUser);
            _controller._UserDatabase = userDatabaseMock.Object;

            // Act
            var result = _controller.UpdateUser(userId, updatedUser);

            // Assert
            Assert.IsType<OkResult>(result);
            Assert.Equal(updatedUser.FirstName, existingUser.FirstName);
            Assert.Equal(updatedUser.LastName, existingUser.LastName);
            Assert.Equal(updatedUser.Age, existingUser.Age);
            Assert.Equal(updatedUser.Sex, existingUser.Sex);
            Assert.Equal(updatedUser.Weight, existingUser.Weight);
            Assert.Equal(updatedUser.DesiredWeight, existingUser.DesiredWeight);
            userDatabaseMock.Verify(db => db.UpdateUser(userId, existingUser), Times.Once);
        }

        [Fact]
        public void UpdateUser_NonExistingUserId_ReturnsNotFound()
        {
            // Arrange
            var userId = 1;
            var updatedUser = new User { Id = userId, FirstName = "Jane", LastName = "Smith" };
            var userDatabaseMock = new Mock<UserDatabase>();
            userDatabaseMock.Setup(db => db.GetUserById(userId)).Returns((User)null);
            _controller._UserDatabase = userDatabaseMock.Object;

            // Act
            var result = _controller.UpdateUser(userId, updatedUser);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void DeleteUser_ExistingUser_ReturnsOk()
        {
            // Arrange
            var user = new User { Id = 1, FirstName = "John", LastName = "Doe" };
            var userDatabaseMock = new Mock<UserDatabase>();
            userDatabaseMock.Setup(db => db.GetUserById(user.Id)).Returns(user);
            _controller._UserDatabase = userDatabaseMock.Object;

            // Act
            var result = _controller.DeleteUser(user);

            // Assert
            Assert.IsType<OkResult>(result);
            userDatabaseMock.Verify(db => db.DeleteUser(user), Times.Once);
        }

        [Fact]
        public void DeleteUser_NonExistingUser_ReturnsNotFound()
        {
            // Arrange
            var user = new User { Id = 1, FirstName = "John", LastName = "Doe" };
            var userDatabaseMock = new Mock<UserDatabase>();
            userDatabaseMock.Setup(db => db.GetUserById(user.Id)).Returns((User)null);
            _controller._UserDatabase = userDatabaseMock.Object;

            // Act
            var result = _controller.DeleteUser(user);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}