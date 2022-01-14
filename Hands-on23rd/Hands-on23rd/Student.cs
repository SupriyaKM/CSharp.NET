using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_on23rd
{
    class Student
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;

        private static double servicetax = 12.3;

        public Student(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public void Payment(int amount)
        {
            feepaid += amount;
        }

        public void Print()
        {
            Console.WriteLine("RollNo:"+rollno);
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Course:"+course);
            Console.WriteLine("Feepaid:"+feepaid);
        }

        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid;
            }
        }

        public int TotalFee
        {
            get
            {
                double total = course == "c#" ? 2000 : 3000;
                // service tax
                total = total + total * (servicetax / 100);
                return (int)total;
            }
        }

        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }
    }
}










  