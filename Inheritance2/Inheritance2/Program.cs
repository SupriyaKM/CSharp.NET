using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main()
        {
            Hp p = new Hp();
            p.Name();
            p.Price();
            p.Ram();
            p.Processor();
            Lenovo l = new Lenovo();
            l.Name();
            l.Price();
            l.Ram();
            l.Processor();
            Console.ReadKey();

        }
    }
}
