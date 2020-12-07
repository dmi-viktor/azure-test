using ExampleProject.Controllers;
using System;
using System.Web.Mvc;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void IndexViewDataMessage()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.Equal("Hello!", result?.ViewData["Message"]);
        }

        [Fact]
        public void Multiplication()
        {
            HomeController controller = new HomeController();
            Decimal result = controller.Multiplication(2, 2);

            Assert.Equal(4, 4);
        }
    }
}
