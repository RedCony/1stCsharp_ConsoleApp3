using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class TeaCher_DicMgr
    {
        //key : 선생님 이름 , value : 선생님 인스턴스
        Dictionary<string,TeaCher> mTeaCher_DictMgr;

        TeaCher teaCher = null;
        List<TeaCher> Temp = null;
        
        public TeaCher_DicMgr() { }
        public TeaCher_DicMgr(int nArrayCnt)
        {
            if (mTeaCher_DictMgr == null)
            {
                mTeaCher_DictMgr = new Dictionary<string, TeaCher>(nArrayCnt);
            }
        }

        ~TeaCher_DicMgr()
        {
            if (mTeaCher_DictMgr != null)
                mTeaCher_DictMgr.Clear();
        }

        string makeKey(eTeacherType etype, string strname, int nAge)
        {
            return strname;// + "-" + etye.ToString() + "-" + nsAge.ToString();
        }
        bool isExistKey(string strkey)
        {
            return mTeaCher_DictMgr.ContainsKey(strkey);
        }

      
        public void CreateTeachers(eTeacherType etype, string strname, int nSalary, int nAge)
        {
            string strkey = makeKey(etype, strname, nAge);
            if(isExistKey(strkey))
            {
                Console.WriteLine("failed Create  {0} 이미 존재 합니다.:", strkey);
                return;
            }

                switch (etype)
                {

                    case eTeacherType.eTeacher_kor:
                        teaCher = new KorTeaCher(strname, nSalary, nAge);
                        mTeaCher_DictMgr.Add(strkey,teaCher);
                        Console.WriteLine("국어 선생님이 생성 되었습니다.");
                        break;

                    case eTeacherType.eTeacher_Music:
                        teaCher = new MusicTeaCher(strname, nSalary, nAge);
                        mTeaCher_DictMgr.Add(strkey, teaCher);
                        Console.WriteLine("음악 선생님이 생성 되었습니다.");
                        break;

                    case eTeacherType.eTeacher_Math:
                        teaCher = new MathTeaCher(strname, nSalary, nAge);
                        mTeaCher_DictMgr.Add(strkey, teaCher);
                        Console.WriteLine("수학 선생님이 생성 되었습니다.");
                        break;

                    default:
                        Console.WriteLine("잘못된 입력입니다.0~2의 숫자를 입력하세요.");
                        break;
                }
            
        }

        public void DisPlayInfo()
        {
            if (mTeaCher_DictMgr == null)
                return;

           foreach(KeyValuePair<string,TeaCher> kv in mTeaCher_DictMgr)
            {
                if (mTeaCher_DictMgr[kv.Key] == null)
                    continue;

                kv.Value.DisPlayInfo();
            }
        }

        public void Teaching()
        {
            if (mTeaCher_DictMgr == null)
                return;

            foreach (KeyValuePair<string, TeaCher> kv in mTeaCher_DictMgr)
            {
                if (mTeaCher_DictMgr[kv.Key] == null)
                    continue;

                kv.Value.Teaching();
            }
        }

        public TeaCher FindTeacher(string strname)
        {
            /* 
           if( !mTeaCher_DictMgr.TryGetValue(strName, out teacher) )
               Console.WriteLine("cant't find : " + strName);
          */
            if (mTeaCher_DictMgr.ContainsKey(strname))
            {
                return mTeaCher_DictMgr[strname];
            }
            return null;
        }

        public void ReMove(string strname)
        {
            mTeaCher_DictMgr.Remove(strname,out teaCher);
            Console.WriteLine("{0} 선생님을 삭제 합니다.\n", strname);
        }


        public  List<KeyValuePair<string,TeaCher>> SortbyName (int na = 0)
        {
            List<KeyValuePair<string,TeaCher>> list = mTeaCher_DictMgr.ToList();

            if (na == 0)  
            {
                list.Sort((x1, x2) => x2.Value.Name.CompareTo(x1.Value.Name));
            }

            else
            {
                list.Sort((x1, x2) => x1.Value.Name.CompareTo(x2.Value.Name));
            }

            foreach (KeyValuePair<string,TeaCher> teaCher in list)
            {
                teaCher.Value.DisPlayInfo();
            }

            return list;
        }


        public List<KeyValuePair<string, TeaCher>> SortLinqByName(int na = 0)
        {
            List<KeyValuePair<string, TeaCher>> SortedList = null;
            if (na == 0)
            {
                SortedList = mTeaCher_DictMgr.OrderBy(x => x.Value.Name).ToList();
            }
            else
            {
                SortedList = mTeaCher_DictMgr.OrderByDescending(x => x.Value.Name).ToList();
            }

            Console.WriteLine("--- -- Linq sort ---- ");
            foreach (KeyValuePair<string, TeaCher> teacher_ in SortedList)
            {
                teacher_.Value.DisPlayInfo();
            }

            return SortedList;
        }


        public List<KeyValuePair<string, TeaCher>> SortbyAge(int na = 0)
        {
           List<KeyValuePair<string, TeaCher>> list = mTeaCher_DictMgr.ToList();

            if (na == 0)
            {
                list.Sort((x1, x2) => x2.Value.Age.CompareTo(x1.Value.Age));
            }

            else
            {
                list.Sort((x1, x2) => x1.Value.Age.CompareTo(x2.Value.Age));
            }

            foreach (KeyValuePair<string, TeaCher> teaCher in list)
            {
                teaCher.Value.DisPlayInfo();
            }
            return list;
        }


        public List<KeyValuePair<string, TeaCher>> SortLinqByAge(int na = 0)
        {
            List<KeyValuePair<string, TeaCher>> SortedList = null;
            if (na == 0)
            {
                SortedList = mTeaCher_DictMgr.OrderBy(x => x.Value.Age).ToList();
            }
            else
            {
                SortedList = mTeaCher_DictMgr.OrderByDescending(x => x.Value.Age).ToList();
            }

            Console.WriteLine("--- -- Linq sort ---- ");
            foreach (KeyValuePair<string, TeaCher> teacher_ in SortedList)
            {
                teacher_.Value.DisPlayInfo();
            }
            return SortedList;
        }


        public List<KeyValuePair<string, TeaCher>> SortbyeType(int na = 0)
        {
            List<KeyValuePair<string, TeaCher>> list = mTeaCher_DictMgr.ToList();

            if (na == 0)
            {
                list.Sort((x1, x2) => x2.Value.eType.CompareTo(x1.Value.eType));
            }

            else
            {
                list.Sort((x1, x2) => x1.Value.eType.CompareTo(x2.Value.eType));
            }

            foreach (KeyValuePair<string, TeaCher> teaCher in list)
            {
                teaCher.Value.DisPlayInfo();
            }
            return list;
        }


        public List<KeyValuePair<string, TeaCher>> SortLinqBeType(int na = 0)
        {
            List<KeyValuePair<string, TeaCher>> SortedList = null;
            if (na == 0)
            {
                SortedList = mTeaCher_DictMgr.OrderBy(x => x.Value.eType).ToList();
            }
            else
            {
                SortedList = mTeaCher_DictMgr.OrderByDescending(x => x.Value.eType).ToList();
            }

            Console.WriteLine("--- -- Linq sort ---- ");
            foreach (KeyValuePair<string, TeaCher> teacher_ in SortedList)
            {
                teacher_.Value.DisPlayInfo();
            }

            return SortedList;
        }











    }
}
