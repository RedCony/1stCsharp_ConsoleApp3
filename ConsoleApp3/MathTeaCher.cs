using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MathTeaCher:TeaCher
    {
        public MathTeaCher() { }

        ~MathTeaCher() { }

        public MathTeaCher(string mstrName, int nSalary, int mnAge)
                           : base(mstrName, nSalary, mnAge) { base.meType = eTeacherType.eTeacher_Math; }

        override public void DisPlayInfo()
        {
            base.DisPlayInfo();
        }
        public void DisPlayAllData()
        {
            base.DisPlayAllData();
        }

        override public void Teaching()
        {
            base.Teaching();
            Console.WriteLine("과목은 수학입니다.\n");
        }

        override public void RestTime()
        {
            base.RestTime();
            Console.WriteLine("교내 운동장에서 산보 합니다.\n");
        }

    }
}
