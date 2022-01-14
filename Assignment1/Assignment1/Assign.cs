using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment1
{
    class Assign
    {

        public void CreateHouse()
        {

            FileStream filestreamObj = new FileStream("F:\\CSp\\sample.txt", FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(filestreamObj);
            int[] id = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter ID: ");
                int Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter source: ");
                int Source = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter destination: ");
                int Destination = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter DateTime: ");
                Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));

                Console.Write("Enter status: ");
                string Status = Console.ReadLine();

                Console.Write("Enter network: ");
                string Network = Console.ReadLine();
                Console.WriteLine("\n");

                sw.WriteLine("ID:" + Id);
                sw.WriteLine("source:" + Source);
                sw.WriteLine("destination:" + Destination);

                sw.WriteLine("status:" + Status);
                sw.WriteLine("network:" + Network + '\n');

            }
            sw.Flush();

            sw.Close();

            filestreamObj.Close();
        }
    }
}
