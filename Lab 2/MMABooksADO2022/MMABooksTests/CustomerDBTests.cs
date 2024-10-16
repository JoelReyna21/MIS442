using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using MMABooksBusinessClasses;
using MMABooksDBClasses;

namespace MMABooksTests
{
    [TestFixture]
    public class CustomerDBTests
    {

        [Test]
        public void TestGetCustomer()
        {
            Customer c = CustomerDB.GetCustomer(1);
            Assert.AreEqual(1, c.CustomerID);
        }

        [Test]
        public void TestCreateCustomer()
        {
            Customer c = new Customer();
            c.Name = "Mickey Mouse";
            c.Address = "101 Main Street";
            c.City = "Orlando";
            c.State = "FL";
            c.ZipCode = "10101";

            int customerID = CustomerDB.AddCustomer(c);
            c = CustomerDB.GetCustomer(customerID);
            Assert.AreEqual("Mickey Mouse", c.Name);
        }
        [Test]

        public void TestUpdateCustomer()
        {
                Customer Oldcustomer = new Customer();
            {
                Oldcustomer.Name = "Mickey Mouse";
                Oldcustomer.Address = "101 Main Street";
                Oldcustomer.City = "Orlando";
                Oldcustomer.State = "FL";
                Oldcustomer.ZipCode = "10101";
            }
                Customer newCustomer = new Customer();
            {
                newCustomer.Name = "Minnie Mouse";
                newCustomer.Address = "735 Main Street";
                newCustomer.City = "Miami";
                newCustomer.State = "FL";
                newCustomer.ZipCode = "49524";
            }
            int customerID = CustomerDB.AddCustomer(newCustomer);
            newCustomer = CustomerDB.GetCustomer(customerID);
            Assert.AreEqual("Mickey Mouse", newCustomer.Name);
        }

        [Test]
        public void TestDeleteCustomer()
        {
           
            Customer c = new Customer
            {
                CustomerID = 700,
                Name = "Mickey Mouse",
                Address = "101 Main Street",
                City = "Orlando",
                State = "FL",
                ZipCode = "10101"
            };

            bool deleteResult = CustomerDB.DeleteCustomer(c);

            
        }







    }
}
