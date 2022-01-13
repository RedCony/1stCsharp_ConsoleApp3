using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class TeaCher : Person
    {
        private int mstrnSalary;
        protected eTeacherType meType = eTeacherType.eTeacher_Max;

        public TeaCher() { }

        ~TeaCher() { }

        public int Salary
        {
            get { return this.mstrnSalary; }
            set { this.mstrnSalary = value; }
        }

        public  eTeacherType eType
        {
            get { return this.meType; }
        }
            


        public TeaCher(string strName,int nSalary,int nAge)
        {
            base.Name = strName;
            this.mstrnSalary = nSalary;
            base.Age = nAge;
        }
        /*
        public TeaCher(eTeacherType ntype,string mstrName, int nSalary, int mnAge)
        {
            this.meType = ntype;
            base.Name = mstrName;
            this.mstrnSalary = nSalary;
            base.Age = mnAge;
        }
        */

        
        virtual public void DisPlayInfo()
        {
            Console.WriteLine("\n이름 : {0}  \n월급 : {1} \n나이 : {2} \n타입 : {3}", base.Name,this.mstrnSalary, base.Age,this.meType.ToString());
        }

        public void DisPlayAllData()
        {
            Console.WriteLine("이름 : {0} 월급 : {1} 나이 : {2} ", base.Name, this.mstrnSalary, base.Age);
        }

        virtual public void Teaching()
        {
            Console.WriteLine("TeaCher {0} 선생님은 수업중입니다.", base.Name);
        }

        virtual public void RestTime()
        {
            Console.WriteLine("TeaCher {0} 지금은 쉬는시간입니다.", base.Name);
        }
    }
}
