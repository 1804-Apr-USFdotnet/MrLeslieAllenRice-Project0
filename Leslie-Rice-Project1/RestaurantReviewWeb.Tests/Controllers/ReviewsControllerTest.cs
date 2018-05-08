using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviewWeb.Controllers;

namespace RestaurantReviewWeb.Tests.Controllers
{
    [TestClass]
    public class ReviewsControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Search()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            string sRestName = "McDonalds";
            string sAddress = "8457 Jump St. Tampa Florida 33601";
            ViewResult result = controller.Search(sRestName, sAddress) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Add()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            string sRestName = "Arbys";
            string sAddress = "5678 Willow Ave. Tampa Florida 33601";
            decimal dRating = 4.67m;
            string sRevSummary = "I cannot get enough of those curly fries! I love them!";
            int iFK_Rid = 1;
            ViewResult result = controller.Add(sRestName, sAddress, dRating, sRevSummary, iFK_Rid) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Edit()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.Edit() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Update()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            string sRestName = "Arbys";
            string sAddress = "5678 Willow Ave. Tampa Florida 33601";
            decimal dRating = 4.67m;
            string sRevSummary = "I cannot get enough of those curly fries! I love them!";
            ViewResult result = controller.Update(sRestName, sAddress, dRating, sRevSummary) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
