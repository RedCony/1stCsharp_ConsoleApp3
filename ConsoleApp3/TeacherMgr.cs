using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class TeacherMgr
    {
        TeaCher[] mteacherMgr;

        public TeacherMgr(int nArrayCnt)
        {
            if (mteacherMgr == null)
                mteacherMgr = new TeaCher[nArrayCnt];
        }

        /*
         public void CreateTeachers(int nctn)
         {
            mteacherMgr = new TeaCher[nctn];

            int nn = 0;

            while (true)
            {
                string str = Console.ReadLine();

                eTeacherType eType = (eTeacherType)Convert.ToInt32(str);

                if (nn > mteacherMgr.Length-1 )
                {
                    Console.WriteLine("입력을 완료하였습니다.");
                    return;
                }
               
                switch (eType)
                {
                    case eTeacherType.eTeacher_kor:
                        mteacherMgr[nn++] = new KorTeaCher();
                        Console.WriteLine("국어 선생님이 생성 되었습니다.");
                        break;

                    case eTeacherType.eTeacher_Music:
                        mteacherMgr[nn++] = new MusicTeaCher();
                        Console.WriteLine("음악 선생님이 생성 되었습니다.");

                        break;

                    case eTeacherType.eTeacher_Math:
                        mteacherMgr[nn++] = new MathTeaCher();
                        Console.WriteLine("수학 선생님이 생성 되었습니다.");
                        break;
                    
                    default:Console.WriteLine("잘못된 입력입니다.0~2의 숫자를 입력하세요.");
                        break;
                }
            }

         }
        */
        /*
        public void CreateTeachers( eTeacherType etype, string strName, int nSalary, int nAge)
        {
            int nn = GetIndex_Valid();

            if (nn == -1)
            {
                Console.WriteLine("유효한 인덱스를 찾지 못해서 {0}을"+ "추가 하지 못했습니다.",strName);
                return;
            }

            switch (etype)
            {
                case eTeacherType.eTeacher_kor:
                    mteacherMgr[nn++] = new KorTeaCher(strName,nSalary,nAge);
                    Console.WriteLine("국어 선생님이 생성 되었습니다.");
                    break;

                case eTeacherType.eTeacher_Music:
                    mteacherMgr[nn++] = new MusicTeaCher(strName,nSalary,nAge);
                    Console.WriteLine("음악 선생님이 생성 되었습니다.");
                    break;

                case eTeacherType.eTeacher_Math:
                    mteacherMgr[nn++] = new MathTeaCher(strName,nSalary,nAge);
                    Console.WriteLine("수학 선생님이 생성 되었습니다.");
                    break;

                default:Console.WriteLine("잘못된 입력입니다.0~2의 숫자를 입력하세요.");
                    break;
            }

        }
        */
        public void CreateTeachers(eTeacherType etype, string strName, int nSalary, int nAge)
        {
            int nn = GetIndex_Valid();

            if (nn == -1)
            {
                Console.WriteLine("유효한 인덱스를 찾지 못해서 {0}을" + "추가 하지 못했습니다.", strName);
                return;
            }
            else if (nn == -2)
            {
                nn = mteacherMgr.Length;
                Resize();
            }

            switch (etype)
            {
                case eTeacherType.eTeacher_kor:
                    mteacherMgr[nn++] = new KorTeaCher(strName, nSalary, nAge);
                    Console.WriteLine("국어 선생님이 생성 되었습니다.");
                    break;

                case eTeacherType.eTeacher_Music:
                    mteacherMgr[nn++] = new MusicTeaCher(strName, nSalary, nAge);
                    Console.WriteLine("음악 선생님이 생성 되었습니다.");
                    break;

                case eTeacherType.eTeacher_Math:
                    mteacherMgr[nn++] = new MathTeaCher(strName, nSalary, nAge);
                    Console.WriteLine("수학 선생님이 생성 되었습니다.");
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다.0~2의 숫자를 입력하세요.");
                    break;
            }

        }

        public void Teaching() 
        {
            if (mteacherMgr == null)
                return;

            for (int nn = 0; nn < mteacherMgr.Length; nn++)
            {
                if (mteacherMgr[nn] == null)
                    continue;

                mteacherMgr[nn].Teaching();
            }

        }

        public int GetIndex_Valid()
        {
            if (mteacherMgr == null)
                return -1;

            int nn = 0;
            for (nn=0;nn< mteacherMgr.Length; nn++)
            {
                if (mteacherMgr[nn] == null)
                    return nn;
            }

            return -2; //배열공간이 없어요.
        }

        public void DisPlayInfo()
        {
            if (mteacherMgr == null)
                return;

            for (int nn = 0; nn < mteacherMgr.Length; nn++)
            {
                if (mteacherMgr[nn] == null)
                    continue;

                mteacherMgr[nn].DisPlayInfo();
            }
        }

        public TeaCher FindTeacher(string strName)
        {
            
            if (mteacherMgr == null)
                return null;
            
            for ( int nn=0;nn<mteacherMgr.Length;nn++)
            {
                if (mteacherMgr[nn] == null)
                    continue;
                if (mteacherMgr[nn].Name == strName)
                    return mteacherMgr[nn];
            }
            Console.WriteLine("{0}없습니다.", strName);
            return null;
        }

        public int FindTeacher_(string strName)
        {

            if (mteacherMgr == null)
                return -1;

            for (int nn = 0; nn < mteacherMgr.Length; nn++)
            {
                if (mteacherMgr[nn] == null)
                    continue;
                if (mteacherMgr[nn].Name == strName)
                    return nn;
            }
            Console.WriteLine("{0}없습니다.", strName);
            return -1;
        }

        public TeaCher[] FindTeachers(string strName)
        {
            TeaCher[] Temp = new TeaCher[10];
            if (mteacherMgr == null)
                return null;

            int nidx = 0;

            for (int nn = 0 ; nn < mteacherMgr.Length ; nn++)
            {
                if (mteacherMgr[nn] == null)
                    continue;
                if (mteacherMgr[nn].Name == strName)
                    Temp[nidx++] = mteacherMgr[nn];
            }
            if (nidx == 0)
                Console.WriteLine("{0}없습니다.", strName);
            return Temp;
        }
        public void Delete(string strname)
        {
            for (int nn = 0; nn < mteacherMgr.Length; nn++)
            {
                if (mteacherMgr[nn] == null)
                {
                      continue;
                }

                if (mteacherMgr[nn].Name == strname)
                {
                     mteacherMgr[nn].Dispose();
                     mteacherMgr[nn] = null;
                    Console.WriteLine("{0} 입니다.", strname);
                }
            }
            
        }

        public void Delete_(string strname)
        {
            int nid = FindTeacher_(strname);
            if (nid == -1)
                return;

            mteacherMgr[nid].Dispose();
            mteacherMgr[nid] = null;
        }

        void Resize()
        {
            int nId = mteacherMgr.Length;
            TeaCher[] temp = new TeaCher[nId];

            for (int nn =0;nn<nId;nn++)         // 새로운 배열을 지정합니다.
            {
                temp[nn] = mteacherMgr[nn];
            }

            mteacherMgr = new TeaCher[nId * 2];  // 스왑합니다.
            for (int nn=0;nn<nId;nn++)
            {
                mteacherMgr[nn] = temp[nn];
            }
        }

      
    }
} 
