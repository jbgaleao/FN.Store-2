using FN.Store.UI.Controllers;
using FN.Store.UI.ViewModels.Produtos.Index;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FN.Store.Testes.UI.Controllers
{
    [TestClass, TestCategory("Controllers/ProdutosController")]
    public class ProdutosControllerTest
    {

        [TestMethod]
        public void MetodoIndexRetornandoViewComModeloCorreto()
        {
            var produtosController = new ProdutosController();

            var result = produtosController.Index();
            var model = result.Model as IEnumerable<ProdutoIndexVM>;

            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }

    }
}
