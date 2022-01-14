using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            int total = 3;

            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                stack.Push(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            for (int i = 0; i < total; i++)
            {
                Person p = (Person)stack.Pop();
                Console.WriteLine(p.ToString());
            }
        }

    }
}

