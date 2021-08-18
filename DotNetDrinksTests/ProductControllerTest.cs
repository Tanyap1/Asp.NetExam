using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetDrinks.Controllers;
using Microsoft.AspNetCore.Mvc;
using DotNetDrinks.Models;

namespace DotNetDrinksTests
{
    [TestClass]
    public class ProductControllerTest
    {
        public object Delete { get; private set; }

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
        //Write a Unit Test for the DeleteConfirmed Post method of the ProductsController that passes in one of the Product objects
        //from the in-memory database and checks that this object is removed from the database successfully.

        [TestMethod]
        public void PostDeleteConfirmedProduct()
        {
            var result = Controller.Delete();
            var viewResult = (ViewResult)result.Delete;
            var model = (List<Product>)viewResult.Model;

            CollectionAssert.AreEqual(Delete.Product.Id, model);
        }




    }



}
