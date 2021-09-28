using System;
using System.Collections.Generic;

namespace products
{
    public class ProductManager : MenuProgram
    {
        private List<Product> products; // null
        private List<Category> categories; // null

        public ProductManager()
        {
            products = new List<Product>();
            categories = new List<Category>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Add product");
            System.Console.WriteLine("2. Add category");
            System.Console.WriteLine("3. Show products");
            System.Console.WriteLine("4. Show category");
            System.Console.WriteLine("5. Search product");
            // HW: 6. Edit product (choose product position in the list), ask user to 
            // enter name, price, category to edit
            // HW: 7. Add produc to category. (choose category, choose product, add product to category)
            System.Console.WriteLine("0. Exit");
        }

        protected override void DoTask(int option)
        {
            switch(option)
            {
                case 1: AddProduct();       break;
                case 2: AddCategory();      break;
                case 3: ShowProducts();     break;
                case 4: ShowCategory();     break;
                case 5: SearchProduct();    break;
                case 0: Quit();             break;
                default: ShowError();       break;
            }
        }

        private void ShowError()
        {
            System.Console.WriteLine("Invalid option!");
        }

        private void Quit()
        {
            System.Console.WriteLine("Program terminates successful.");
        }

        private void SearchProduct()
        {
            // ask user to enter product name
            // use for (foreach) to search a produc with that name
            // print product if found, else print not found
        }

        private void ShowCategory()
        {
            // use for (foreach) loop to print out all categories
        }

        private void ShowProducts()
        {
            // use for (foreach) loop to print out all products
            foreach (Product p in products)
            {
                System.Console.WriteLine(p);
            }
        }

        private void AddCategory()
        {
            // enter category info
            System.Console.Write("Enter category name: ");
            string name = Console.ReadLine();
            // create Category object
            Category c = new Category(name);
            // add c to categories
            categories.Add(c);
        }

        private void AddProduct()
        {
            // enter product info
            System.Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter product price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            
            // create Product object
            Product p = new Product(name, price);
            
            // show categories
            for (int i = 0; i < categories.Count; i++)
            {
                System.Console.WriteLine(i + ". " + categories[i]);
            }
            // choose category
            System.Console.Write("Enter category id: ");
            int catID = Convert.ToInt32(Console.ReadLine()); // HW: validate catID
            p.Cat = categories[catID];
            // add product to category
            categories[catID].AddProduct(p);
            // add product p to products
            products.Add(p);
        }
    }
}