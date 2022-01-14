using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Laptop
    {
        public virtual void Name()
        {
            Console.WriteLine("Name");
        }
        public virtual void Price()
        {
            Console.WriteLine("Price");
        }
        public virtual void Ram()
        {
            Console.WriteLine("RAM");
        }
        public virtual void Processor()
        {
            Console.WriteLine("Processor");
        }
    }
}
