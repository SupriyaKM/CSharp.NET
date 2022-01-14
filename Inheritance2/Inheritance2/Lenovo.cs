using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Lenovo : Laptop
    {
        public override void Name()
        {
            Console.WriteLine("Name:Lenovo");
        }
        public override void Price()
        {
            Console.WriteLine("Price:Rs.24000");
        }
        public override void Ram()
        {
            Console.WriteLine("RAM:8 GB");
        }
        public override void Processor()
        {
            Console.WriteLine("Processor:i2");
        }
    }
}
