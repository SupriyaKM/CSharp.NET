using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
                Student s = new Student(1, "ABC", "c#");
                s.Payment(1000);
                s.Print();
            Console.WriteLine("TotalFee:" + s.TotalFee);
            Console.WriteLine("DueAmount:"+s.DueAmount);
            }
    }
}


   