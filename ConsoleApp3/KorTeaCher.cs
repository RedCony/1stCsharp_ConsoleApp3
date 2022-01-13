using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class KorTeaCher:TeaCher
    {
        private int mDonation;
        public KorTeaCher() { }

        ~KorTeaCher() { }

        public int nDonation
        {
            get { return this.mDonation; }
            set { this.mDonation = value; }
        }

        public KorTeaCher(string strName, int nSalary, int nAge)
                          : base(strName, nSalary, nAge)
        { 
            base.meType = eTeacherType.eTeacher_kor;
            nDonation = (int)((double)nSalary * ((double)5 / (double)100));
        }
        /*
        public KorTeaCher(string mstrName, int nSalary, int mnAge,int nndonation)
        {
            base.Name = mstrName;
            base.Salary = nSalary;
            base.Age = mnAge;
            this.mDonation = nndonation;

            base.meType = eTeacherType.eTeacher_kor;
        }
        */
        override public void DisPlayInfo()
        {
            base.DisPlayInfo();
            Console.Write("기부금 : {0} ", this.mDonation);
        }

        public void DisPlayAllData() 
        {
            base.DisPlayAllData();
        }

        override public void Teaching()
        {
            base.Teaching();
            Console.WriteLine("과목은 국어 입니다.");
        }

        override public void RestTime()
        {
            base.RestTime();
            Console.WriteLine("영어를 공부합니다.");
        }


    }
}
