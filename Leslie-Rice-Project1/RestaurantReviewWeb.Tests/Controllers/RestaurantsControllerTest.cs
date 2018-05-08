using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviewWeb.Controllers;

namespace RestaurantReviewWeb.Tests.Controllers
{
    [TestClass]
    public class RestaurantsControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            RestaurantsController controller = new RestaurantsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            RestaurantsController controller = new RestaurantsController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Add()
        {
            // Arrange
            RestaurantsController controller = new RestaurantsController();

            // Act
            string sRestName = "Jimmy Johns";
            string sAddress = "4021 Pine St. Tampa Florida 33601";
            ViewResult result = controller.Add(sRestName, sAddress) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            RestaurantsController controller = new RestaurantsController();

            // Act
            string sRestName = "Jimmy Johns";
            ViewResult result = controller.Delete(sRestName) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Edit()
        {
            // Arrange
            RestaurantsController controller = new RestaurantsController();

            // Act
            ViewResult result = controller.Edit() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Update()
        {
            // Arrange
            RestaurantsController controller = new RestaurantsController();

            // Act
            string sRestName = "Arbys";
            string sAddress = "5678 Willow Ave. Tampa Florida 33601";
            ViewResult result = controller.Update(sRestName, sAddress) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
