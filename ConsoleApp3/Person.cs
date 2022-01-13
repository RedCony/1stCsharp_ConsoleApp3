using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Person:IDisposable
    {
        private string mstrName;
        protected int msrtAge;
        protected string mstrHobby;

        public Person() { }
        ~Person() { }

        public void ToDo() { }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public string Name
        {
            get { return this.mstrName; }
            set { this.mstrName = value; }
        }

        public int Age
        {
            get { return this.msrtAge; }
            set { this.msrtAge = value; }
        }

        public string Hobby
        {
            get { return this.mstrHobby; }
            set { this.mstrHobby = value; }
        }

        public void Wakeup()
        {
            Console.WriteLine("Person {0} 은 일어났습니다.", this.mstrName);
        }
        public void Sleep()
        {
            Console.WriteLine("{0}은 자고 있습니다.", this.mstrName);
        }


    }

   
}
