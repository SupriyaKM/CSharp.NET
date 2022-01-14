using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrRev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string input = Console.ReadLine();
            input = input.Replace(" ", string.Empty);

            while(input.Length>0)
            {
                Console.Write(input[0] + ":");
                int count = 0;
                for(int i=0;i<input.Length;i++)
                {
                    if(input[0] == input[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            }
        }
    }
}
