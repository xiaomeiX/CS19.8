using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication6;
using WebApplication6.Controllers;
using WebApplication6.Models;

namespace WebApplication6.Tests.Models
{
    [TestClass]
    public class HomeModelUnitTests
    {
        [TestMethod]
        public void Models_HomeModels_Instantiate_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new HomeModel();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
