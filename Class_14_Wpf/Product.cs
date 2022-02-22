using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14_Wpf
{
    public enum ProductTypes
    {
        Food,
        Technic
    }

    public class Product
    {
        public string ProductName { get; set; } 
        public int Price { get; set; }  
        public string ImageName { get; set; }          
        public ProductTypes ProductType { get; set; } 
        public override string ToString()
        {
            return ProductName; 
        }
    }
}
