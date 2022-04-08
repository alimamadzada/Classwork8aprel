using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Models
{
    class ProductItem
    {

        public Product product { get; set; }
        public int Id { get; set; }
        public int Count { get; set; }
        public double TotalPrice { get => product.Price * Count; }
    }
}
