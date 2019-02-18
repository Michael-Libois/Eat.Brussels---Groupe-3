using System;
using System.Data.Entity;
using ContextWithEntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Moq;

namespace Repositories.Tests
{
    [TestClass]
    public class UserRepoTests
    {
        [TestInitialize]
        public void Init()
        {
            mockSet = new Mock<DbSet<User>>();
            mockContext = new Mock<DatabaseContext>();

            user = new User
            {
                Email = "milpoub@gmail.com",
                LastName = "Libois",
                FirstName = "Michael"
            };
        }
        Mock<DbSet<User>> mockSet;
        Mock<DatabaseContext> mockContext;
        UserRepo service;
        User user;


        [TestMethod]
        public void CreateUser()
        {
            //Arrange
            string mail = "milpoub@gmail.com";
            string LastName = "Libois";
            string FirstName = "Michael";


            //Act
            mockContext.Setup(u => u.Users).Returns(mockSet.Object);
            service = new UserRepo(mockContext.Object);
            var userExpected = service.Create(user);

            //Assert
            Assert.AreEqual(userExpected.Email, mail);
            Assert.AreEqual(userExpected.LastName, LastName);
            Assert.AreEqual(userExpected.FirstName, FirstName);
            mockSet.Verify(u => u.Add(It.IsAny<User>()), Times.Once());
            mockContext.Verify(u => u.SaveChanges(), Times.Once());
        }
    }
}
