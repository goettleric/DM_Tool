using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DM_Tool.Controllers;
using System.Web.Mvc;


namespace DM_Tool.Tests.Controllers
{
    [TestClass]
    public class PlayerControllerTest
    {
        [TestMethod]
        public void Create()
        {
            PlayersController playersTest = new PlayersController();

            ViewResult result = playersTest.Create() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
