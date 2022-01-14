using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_on23rd
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Supriya", "c#");
            s.Payment(1000);
            s.Print();
            Console.WriteLine("TotalFee:" + s.TotalFee);
            Console.WriteLine("DueAmount:" + s.DueAmount);
        }
    }
}
