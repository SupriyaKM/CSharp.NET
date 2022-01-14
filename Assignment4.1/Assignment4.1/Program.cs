﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            int total = 3;
            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                list.Add(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }      
    }
}
    
