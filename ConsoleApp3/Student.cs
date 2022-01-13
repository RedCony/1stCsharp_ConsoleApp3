using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student:Person
    {
        protected string mstrSchool;
        protected string mstrKeyNo;

        public Student() { }

        ~Student() { }

        public string School
        {
            get { return this.mstrSchool; }
            set { this.mstrSchool = value; }
        }

        public string KeyNo
        {
            get { return this.mstrKeyNo; }
            set { this.mstrKeyNo = value; }
        }

      
        public void Eating()
        {
            Console.WriteLine("{0}학생은 식사를 하고 있습니다.", Name);
           
        }

        public void Studing()
        {
            Console.WriteLine("{0}학생은 공부를 하고 있습니다.", Name);
        }

    }
}
