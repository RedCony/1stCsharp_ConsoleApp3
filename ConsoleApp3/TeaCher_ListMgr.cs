using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class TeaCher_ListMgr
    {
         List<TeaCher> mTeaCher_ListMgr;

        TeaCher teaCher = null;

        public TeaCher_ListMgr() { }

        public TeaCher_ListMgr(int nArrayCnt)
        {
           if( mTeaCher_ListMgr == null)
            {
                mTeaCher_ListMgr = new List<TeaCher>(nArrayCnt);
            }
        }
        ~TeaCher_ListMgr()
        {
            if (mTeaCher_ListMgr != null)
                mTeaCher_ListMgr.Clear();
        }

        public void CreateTeachers(eTeacherType etype, string strname, int nSalary, int nAge)
        {
           
            switch (etype)
            {
                
                case eTeacherType.eTeacher_kor:
                    teaCher= new KorTeaCher(strname, nSalary, nAge);
                    mTeaCher_ListMgr.Add(teaCher); 
                    Console.WriteLine("국어 선생님이 생성 되었습니다.");
                    break;

                case eTeacherType.eTeacher_Music:
                    teaCher = new MusicTeaCher(strname, nSalary, nAge);
                    mTeaCher_ListMgr.Add(teaCher) ;
                    Console.WriteLine("음악 선생님이 생성 되었습니다.");
                    break;

                case eTeacherType.eTeacher_Math:
                    teaCher = new MathTeaCher(strname, nSalary, nAge);
                    mTeaCher_ListMgr.Add(teaCher) ;
                    Console.WriteLine("수학 선생님이 생성 되었습니다.");
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다.0~2의 숫자를 입력하세요.");
                    break;
            }

        }

        public void Teaching()
        {
            if (mTeaCher_ListMgr == null)
                return;

            for (int nn = 0; nn < mTeaCher_ListMgr.Count; nn++)
            {
                if (mTeaCher_ListMgr[nn] == null)
                    continue;

                mTeaCher_ListMgr[nn].Teaching();
            }

        }
        
        public int GetIndex_Valid()
        {
            if (mTeaCher_ListMgr == null)
                return -1;

            int nn = 0;
            for (nn = 0; nn < mTeaCher_ListMgr.Count; nn++)
            {
                if (mTeaCher_ListMgr[nn] == null)
                    return nn;
            }

            return -2; //배열공간이 없어요.
        }
       
        
        public void DisPlayInfo()
        {
            if (mTeaCher_ListMgr == null)
                return;

            for (int nn = 0; nn < mTeaCher_ListMgr.Count; nn++)
            {
                if (mTeaCher_ListMgr[nn] == null)
                    continue;

                mTeaCher_ListMgr[nn].DisPlayInfo();
            }

        }

       
        public TeaCher FindTeacher(string strName)
        {
            TeaCher sada = mTeaCher_ListMgr.Find(x => x.Name == strName);
            return sada;
        }

        /*
        public int FindTeacher_(string strName)
        {

            if (mteacher_ListMgr == null)
                return -1;

            for (int nn = 0; nn < mteacher_ListMgr.Length; nn++)
            {
                if (mteacher_ListMgr[nn] == null)
                    continue;
                if (mteacher_ListMgr[nn].Name == strName)
                    return nn;
            }
            Console.WriteLine("{0}없습니다.", strName);
            return -1;
        }
        */
        
        public  TeaCher[] FindTeachers(string strName)
        {
            TeaCher[] Temp = null;
            List<TeaCher> techersList = mTeaCher_ListMgr.FindAll(x => x.Name == strName);
           if(techersList.Count == 0)
            {
                Console.WriteLine("잘못 입력하였습니다.{0}", strName);
                return null;
            }
            Temp = techersList.ToArray();
            return Temp;
        }

        public void ShortName(int na)
        {
            List<TeaCher> Temp = null;
            if (na == 0)
            {
                Temp = mTeaCher_ListMgr.OrderBy(x => x.Name).ToList();
            }

            else
            {
                Temp = mTeaCher_ListMgr.OrderByDescending(x => x.Name).ToList();
            }

            foreach (TeaCher teaCher_ in Temp)
            {
                teaCher_.DisPlayInfo();
            }
        }

        public void ShortAge(int na)
        {
            List<TeaCher> Temp = null ;
            if (na == 0)
            {
                Temp = mTeaCher_ListMgr.OrderBy(x => x.Age).ToList();
            }

            else
            {
                Temp = mTeaCher_ListMgr.OrderByDescending(x => x.Age).ToList();
            }

            foreach (TeaCher teaCher_ in Temp)
            {
                teaCher_.DisPlayInfo();
            }
        }

        public void ShortType(int na)
        {
            List<TeaCher> Temp = null;
            if (na == 0)
            {
                Temp = mTeaCher_ListMgr.OrderBy(x => x.eType).ToList();
            }

            else
            {
                Temp = mTeaCher_ListMgr.OrderByDescending(x => x.eType).ToList();
            }

            foreach (TeaCher teaCher_ in Temp)
            {
                teaCher_.DisPlayInfo();
            }
        }


        public void ReMove(string strname)
        {
            mTeaCher_ListMgr.Remove(FindTeacher(strname));
            Console.WriteLine("{0} 선생님을 삭제 합니다.", strname);
        }
       
 /*       public void Delete_(string strname)
        {
            int nid = FindTeacher_(strname);
            if (nid == -1)
                return;

            mteacher_ListMgr[nid].Dispose();
            mteacher_ListMgr[nid] = null;
   */     }

  /*  
        void Resize()
        {
            int nId = mteacher_ListMgr.Length;
            TeaCher[] temp = new TeaCher[nId];

            for (int nn = 0; nn < nId; nn++)         // 새로운 배열을 지정합니다.
            {
                temp[nn] = mteacher_ListMgr[nn];
            }

            mteacher_ListMgr = new TeaCher[nId * 2];  // 스왑합니다.
            for (int nn = 0; nn < nId; nn++)
            {
                mteacher_ListMgr[nn] = temp[nn];
            }
        }
        */

    
}

