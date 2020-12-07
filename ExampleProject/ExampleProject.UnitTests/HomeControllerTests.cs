using System;
using System.Web.Mvc;
using ExampleProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleProject.UnitTests
{
    [TestClass]
    public class HomeControllerTests
    {
        //[TestMethod]
        //public void IndexViewDataMessage()
        //{           

        //    // Arrange
        //    HomeController controller = new HomeController();

        //    //// Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    String value = result?.ViewData["Message"].ToString();

            

        //    // Assert
        //    Assert.AreEqual("Hello!", value);
        //}

        [TestMethod]
        public void Multiplication()
        {
            HomeController controller = new HomeController();
            Decimal result = controller.Multiplication(2, 2);

            Assert.AreEqual(4, 4);
        }
    }
}
