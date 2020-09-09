using SimpleWebHalloWorld.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SimpleWebHalloWorld.Test
{
    public class IsOutPutHelloWorld
    {

        [Fact]
        public void ShouldReturnHelloWorld()
        {
            var controller = new HomeController();
            var result = controller.ReturnHelloWorld("Hello This test fails");
            Assert.True(result);

        }
    }
}
