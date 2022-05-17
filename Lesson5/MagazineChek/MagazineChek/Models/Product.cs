using System;
using System.Collections.Generic;
using System.Text;

namespace MagazineChek.Models
{
    internal class Product
    {
        public string Name { get; set; }    
        public byte Price { get; set; }
        public Product(string name , byte price)
        {
            Name = name;
            Price = price;  
        }
        public override string ToString()
        {
            return $"Name:{Name} Price:{Price} ";
        }
    }
}
