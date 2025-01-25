using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStoreApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
       
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImagePath { get; set; } // Path to the product image
        public  ICollection<ProductsCategories> Categories { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
