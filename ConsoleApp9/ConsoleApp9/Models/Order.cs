using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Models
{
    class Order
    {
        
        public int Id { get; set; }
        public int OrderPrice { get; set; }
        public List<ProductItem> PI { get; set; }
    }
}
