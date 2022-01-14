using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Hp : Laptop
    {
        public override void Name()
        {
            Console.WriteLine("Name:HP");
        }
        public override void Price()
        {
            Console.WriteLine("Price:Rs.25000");
        }
        public override void Ram()
        {
            Console.WriteLine("RAM:16 GB");
        }
        public override void Processor()
        {
            Console.WriteLine("Processor:i3");
        }
    }
}
