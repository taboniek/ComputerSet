using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monitors
{
    public class Disc
    {
        public Disc(string name, float priced)
        {
            Name = name;
            PriceD = priced;
        }

        public string Name { get; set; }
        public float PriceD { get; set; }

        
    }
}
