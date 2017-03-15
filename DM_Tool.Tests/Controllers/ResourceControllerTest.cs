using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DM_Tool.Controllers;
using System.Web.Mvc;

namespace DM_Tool.Tests.Controllers
{
    [TestClass]
    public class ResourceControllerTest
    {
        [TestMethod]
        public void Index()
        {
            ResourcesController playersTest = new ResourcesController();

            ViewResult result = playersTest.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
