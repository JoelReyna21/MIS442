using System;
using System.Collections.Generic;
using System.Text;

namespace MMABooksBusinessClasses
{
    public class Product
    {
        public Product() { }

        public Product(string productcode, string description, int unitprice, int onhandquantity)
        {
            ProductCode = productcode;
            Description = description;
            UnitPrice = unitprice;
            OnHandQuantity = onhandquantity;
        }

        public string ProductCode { get; set; }

        public string Description { get; set; }

        public int UnitPrice { get; set; }

        public int OnHandQuantity { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
