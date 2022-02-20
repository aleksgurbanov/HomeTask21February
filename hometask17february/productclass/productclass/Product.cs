using System;
using System.Collections.Generic;
using System.Text;

namespace productclass
{
    class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public double Totalincome;

        public Product (string name)
        {
            Name = name;
        }
        public void Sell ()
        {
            if(Count > 0)
            {
                Count--;
                Totalincome += Price;

            }
            else
            {
                Console.WriteLine("secdiyiniz mehsuldan qalmayib.");
            }
        }

    }
}
