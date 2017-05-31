using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics
{
    class Products
    {

        public string Name;
        public string Description;
        public int Price;

        public Products (string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public string productsshow()
        {
            return Name + "\n" + Description + "\n" + Price;
        }


    }
}
