using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class suKnife
    {
        public void Attck()
        {
            Console.WriteLine("{0}찌르다.");
        }
    }
    class suKnight:Person
    {
        int mnPower = 100;
        suKnife mknife;

        public int Power
        {
            get { return this.mnPower; }
            set { this.mnPower = value; }
        }

        public void Attck()
        {
            mknife.Attck();
        }

        public suKnight(string mstrName, int mnPower)
        {
            this.Name = mstrName;
            this.mnPower = mnPower;
            mknife = new suKnife();
        }

        public suKnight() { }

        ~suKnight() { }
    }
}
