using System;
using Xunit;
using Moq;
using DependencyInjection.Models;
using DependencyInjection.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void controllerTest()
        {
            var data = new[] { new Product { Name = "AAA", Price = 200M } };
            var mosk = new Mock<IRepostitory>();
            mosk.SetupGet(m => m.Products).Returns(data);
            HomeController controller = new HomeController { Repostitory = mosk.Object };
            ViewResult result = controller.Index();
            Assert.Equal(data, result.ViewData.Model);
        }
    }
}
