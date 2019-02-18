using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;
using Models;
using ContextWithEntityFramework;

namespace Repositories.Tests
{
    /// <summary>
    /// Description résumée pour RestaurantRepoTest
    /// </summary>
    [TestClass]
    public class RestaurantRepoTest
    {
        public RestaurantRepoTest()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        //private TestContext testContextInstance;

        ///// <summary>
        /////Obtient ou définit le contexte de test qui fournit
        /////des informations sur la série de tests active, ainsi que ses fonctionnalités.
        /////</summary>
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestInitialize]
        public void Init()
        {
            mockSet = new Mock<DbSet<Restaurant>>();
            mockContext = new Mock<DatabaseContext>();
            resto = new Restaurant
            {
                Name = "Colpan",
                PhoneNumber = "1234",
                StreetNumber = "1",
                Street = "Rue des palais",
                City = "Bruxelles",
                PostalCode = "1000",
            };
        }
        Mock<DbSet<Restaurant>> mockSet;
        Mock<DatabaseContext> mockContext;
        RestaurantRepo service;
        Restaurant resto;

        [TestMethod]
        public void CreateRestaurant()
        {
            //Arrange
            string Name = "Colpan";
            string PhoneNumber = "1234";
            string StreetNumber = "1";
            string Street = "Rue des palais";
            string City = "Bruxelles";
            string PostalCode = "1000";


            //Act
            mockContext.Setup(u => u.Restaurants).Returns(mockSet.Object);
            service = new RestaurantRepo(mockContext.Object);
            var restoExpected = service.Create(resto);

            //Assert
            Assert.AreEqual(restoExpected.Name, Name);
            Assert.AreEqual(restoExpected.PhoneNumber, PhoneNumber);
            Assert.AreEqual(restoExpected.StreetNumber, StreetNumber);
            Assert.AreEqual(restoExpected.Street, Street);
            Assert.AreEqual(restoExpected.City, City);
            Assert.AreEqual(restoExpected.PostalCode, PostalCode);



            mockSet.Verify(u => u.Add(It.IsAny<Restaurant>()), Times.Once());
            mockContext.Verify(u => u.SaveChanges(), Times.Once());
        }
    }
}
