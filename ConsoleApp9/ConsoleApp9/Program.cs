using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\Ali Mamadzada BP101\Desktop\Files");
            File.Create(@"C:\Users\Ali Mamadzada BP101\Desktop\Files\shop.json");

            Product iphone = new Product { Id = 01, Name = "Iphone", Price = 3500 };
            Product samsung = new Product { Id = 02, Name = "S20 Ultra", Price = 2000 };

            ProductItem pi1 = new ProductItem { Id = 01, Count = 3, product = iphone };
            ProductItem pi2 = new ProductItem { Id = 02, Count = 5, product = samsung };

            List<ProductItem> Pi = new List<ProductItem>();
            Pi.Add(pi1);
            Pi.Add(pi2);

            Order o1 = new Order { Id = 001, PI = Pi, OrderPrice = 150 };

            StreamWriter sw = new StreamWriter(@"C:\Users\Ali Mamadzada BP101\source\repos\ConsoleApp9\ConsoleApp9\json1.json");
        }
    }
}
