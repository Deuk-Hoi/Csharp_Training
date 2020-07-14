using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return this.Name + " : " + this.Price;
        }
    }
}
