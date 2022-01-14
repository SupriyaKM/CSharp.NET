using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        
        private int rollno;
        private string name;
        private string course;
        private int feepaid;

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
            Console.WriteLine("rollno:"+rollno);
            Console.WriteLine("name:"+name);
            Console.WriteLine("course:"+course);
            Console.WriteLine("feepaid:"+feepaid);
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
                return course == "c#" ? 2000 : 3000;
            }
        }
    }

}

