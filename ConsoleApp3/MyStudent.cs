using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MyStudent:Person
    {
        protected string mstrKeyNo;
        protected string mstrSchool;

        public MyStudent()
        {
            Console.WriteLine("디폴트 생성자 : MyStudent");
        }

        public  MyStudent(string mstrName, string mstrKeyNo, int mnAge)
        {
            base.Name = mstrName;
            this.mstrKeyNo = mstrKeyNo;
            base.Age = mnAge;
           // Console.WriteLine("생성자 오버로딩 :MyStudent");
        }

        ~MyStudent()
        {
            Console.WriteLine("삭제 됨");
        }
       
       

        public void DisPlayAllData()
        {
            Console.WriteLine("이름 : {0} 학번 : {1} 나이 : {2} 학교 : {3}",base.Name,this.mstrKeyNo,base.Age,this.mstrSchool);
        }

     
        public string KeyNo
        {
            get { return this.mstrKeyNo; }
            set { this.mstrKeyNo = value; }
        }
      

        public string School
        {
            get { return this.mstrSchool; }
            set { this.mstrSchool = value; }
        }
        public MyStudent GetInstance()
        {
            return this;
        }

        public MyStudent(MyStudent data_)
        {
            base.Name = data_.Name;
            this.mstrKeyNo = data_.KeyNo;
            base.Age = data_.Age;
        }

        public void Eating()
        {
            Console.WriteLine("{0}학생은 식사를 하고 있습니다.", base.Name);

        }

        public void Studing()
        {
            Console.WriteLine("{0} 학생은 공부를 하고 있습니다.", base.Name);
        }

        public void Wakeup()
        {
            base.Wakeup();
            Console.WriteLine("MyStudent {0} 은 일어나면서 공복에 물 한 잔을 마십니다.", base.Name);
        }
    }
}
