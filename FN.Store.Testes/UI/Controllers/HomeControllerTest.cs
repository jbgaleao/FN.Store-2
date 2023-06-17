using FN.Store.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace FN.Store.Testes.UI.Controllers
{
    [TestClass, TestCategory("Controllers/HomeController")]
    public class HomeControllerTest
    {

        [TestMethod]
        public void MetodoIndexRetornandoUmaView()
        {
            var homeController = new HomeController();
            var result = homeController.Index();
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }

    }
}
