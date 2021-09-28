using System;
using System.Collections.Generic;

namespace products
{
    public class Category
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value;}
        }        

        private List<Product> products;
        
        public List<Product> Products
        {
            get { return products; }                
        }

        public Category()
        {
            name = "No name";
            products = new List<Product>(); // initiate products object
        }

        public Category(string name)
        {
            Name = name;
            products = new List<Product>(); // initiate products object
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}