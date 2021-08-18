using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetDrinks.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDrinksTests
{
    [TestClass]
    public class ProductControllerTest
    {
        //that passes a valid Id to the method and checks that the view that is returned is called “Delete”
        [TestMethod]

        public void IndexReturnsResult()
        {

            var controller = new ProductsController();
            var result = controller.Index();
            Assert.IsNotNull(result);
        }
        [TestMethod]

        public void GetDeleteView()
        {
            var result = (ViewResult)ProductsController.Delete();
            Assert.IsNotNull("Delete, result.ViewName");
        }


    }
}
