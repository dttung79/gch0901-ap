using System;

namespace products
{
    public class Product
    {
        private int id;
        public int ID 
        {
            get { return id; }
        } 
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; } // validate name # empty
        }
        private int price;

        public int Price 
        {
            get { return price; }
            set { price = value; } // validate price > 0
        }
        private Category cat;

        public Category Cat
        {
            get { return cat; }
            set { cat = value; } // no need to validate
        }

        private static int count = 0;

        public Product()
        {
            id = ++count;
            name = "No name";
            price = 0;
            cat = null;
        }

        public Product(string name, int price)
        {
            id = ++count;
            Name = name;
            Price = price;
            Cat = null;
        }

        public override string ToString()
        {
            string info = "Product name: " + name + "\n";
            info += "Product price: " + price + "\n";
            info += "Category: " + cat + "\n";
            return info;
        }


    }
}