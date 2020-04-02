using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monitors
{
    public class Monitor
    {
        public Monitor(string brand, float price, string diagonal)
        {
            Brand = brand;
            Price = price;
            Diagonal = diagonal;
        }

        public string Brand { get; set; }
        public float Price { get; set; }
        public string Diagonal { get; set; }

    } 
}
