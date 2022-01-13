using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MusicTeaCher:TeaCher
    {
        private int mSelfDevelop;
        public  MusicTeaCher() { }

        ~MusicTeaCher() { }

        public int nSelfDevelop
        {
            get { return this.mSelfDevelop; }
            set { this.mSelfDevelop = value; }
        }

        public MusicTeaCher(string strName, int nSalary, int nAge)
                            : base(strName, nSalary, nAge) 
        { 
            base.meType = eTeacherType.eTeacher_Music;
            nSelfDevelop = (int)((double)nSalary * ((double)20 / (double)100));
        }
        /*
        public MusicTeaCher(string mstrName, int nSalary, int mnAge, int nnSelfDevelop)
        {
            base.Name = mstrName;
            base.Salary = nSalary;
            base.Age = mnAge;
            this.mSelfDevelop = nnSelfDevelop;

            base.meType = eTeacherType.eTeacher_kor;
        }
        */
        override public void DisPlayInfo()
        {
            base.DisPlayInfo();
            Console.WriteLine("자기개발비 : {0} ", this.mSelfDevelop);
        }
        public void DisPlayAllData()
        {
            base.DisPlayAllData();
        }

        override public void Teaching()
        {
            base.Teaching();
            Console.WriteLine("과목은 음악입니다.");
        }

        override public void RestTime()
        {
            base.RestTime();
            Console.WriteLine("스마트폰 게임을 합니다.");
        }

    }
}
