using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using JenkinsUnit.Controllers;

namespace TestProject
{
    public class HomeControllerTest
    {

        [Fact]
        public void Test_Index_ReturnsViewName()
        {

            var homeController = new HomeController();
            var result = homeController.Index() as ViewResult;
            Assert.Equal("Index", result?.ViewName);

        }
    }
}
