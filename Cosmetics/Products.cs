using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics
{
    class Products
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public void Product(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }


    }
}
