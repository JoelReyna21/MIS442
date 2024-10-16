using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using MMABooksBusinessClasses;
using MMABooksDBClasses;

namespace MMABooksTests
{
    [TestFixture]
    public class ProductDBTests
    {
        [Test]
        public void TestGetProduct()
        {
            Product p = ProductDB.GetProduct(1);
            Assert.AreEqual(1, p.ProductCode);

        }
        [Test]

        public void TestCreateProduct()
        {
            Product p = new Product();
            p.ProductCode = "HY8P";
            p.Description = "Introduction to Technical Writing - 9th Edition";
            p.UnitPrice = 42;
            p.OnHandQuantity = 4000;

            string ProductCode = ProductDB.AddProduct(p);
            p = ProductDB.GetProduct(ProductCode);
            Assert.AreEqual("HY8P", p.Description);
        }
        [Test]

        public void TestUpdateProduct()
        {
            Product Oldproduct = new Product();
            {
                Oldproduct.ProductCode = "HY8P";
                Oldproduct.Description = "Introduction to Technical Writing - 9th Edition";
                Oldproduct.UnitPrice = 42;
                Oldproduct.OnHandQuantity = 4000;
            
            }
            Product Newproduct = new Product();
            {
                Newproduct.ProductCode = "MY3L";
                Newproduct.Description = "SQL Database Design for Everyone - 2nd Edition";
                Newproduct.UnitPrice = 50;
                Newproduct.OnHandQuantity = 2000;
                
            }
            string ProductCode = ProductDB.AddProduct(Newproduct);
            Newproduct = ProductDB.GetProduct(ProductCode);
            Assert.AreEqual("MY3L", Newproduct.Description);
        }
        [Test]

        public void TestDeleteProduct()
        {
            Product p = new Product
            {
                ProductCode = "MY3L",
                Description = "SQL Database Design for Everyone - 2nd Edition",
                UnitPrice = 50,
                OnHandQuantity = 2000,
               
            };

            bool deleteResult = ProductDB.DeleteProduct(p);
        }
    }
}
