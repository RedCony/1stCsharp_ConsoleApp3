using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class myfunctions
    {
        public int mnWheel = 2;
        public int mnHandle = 1;
        public int mnSaddle = 1;
        public string mstrHandleType = "barType";

        static public int Ret()
        {
            return 1000;
        }

        static public int Add_100(int na)
        {
            return na + 100;
        }

        static public int Add(int na, int nb)
        {
            return na + nb;
        }

        static public float Add(float fa, float fb)
        {
            return fa + fb;
        }
        static public int Rtn_big(int na, int nb)
        {
            if(na > nb)
            {
                return na;
            }
            else
            {
                return nb;
            }
        }
        static public int Rtn_bigA(int na, int nb)
        {
            return (na > nb) ? na : nb;
        }

        static public int Multi(int na,int nb)
        {
            return na * nb;
        }
        static public void Print_99Dan(int nx)
        {
            for (int ny = 1; ny < 10; ny++)
            {
                Console.WriteLine("{0} * {1} = {2}", nx, ny, nx * ny);
            }
        }
        static public char[] MyStrCpy(char[]cSrc,char[]cDest)
        {
            for (int nn =0; nn < cSrc.Length; nn++)
            {
                cDest[nn] = cSrc[nn];
            }
            return cDest;
        }
        static public char[] MyStrCpy_reverse(char[] cSrc, char[] cDest)
        {
            int ndest = 0;
            for (int nn = cSrc.Length-1; nn >= 0; nn--)
            {
                cDest[ndest++] = cSrc[nn];
            }
            return cDest;
        }
        static public char[] MyStrCpy_ctn(char[] cSrc,int nctn)
        {
            char[] cDest = new char[nctn];
            for (int nn = 0; nn < nctn; nn++)
            {
                cDest[nn] = cSrc[nn];
            }
            return cDest;
        }
        static public char[] MyStrCpy2(char[] cSrc, char[] cDest)
        {
            char[] cMult = new char[cSrc.Length +cDest.Length];
            for (int nn =0; nn < cSrc.Length ; nn++)
            {
                cMult[nn++]= cSrc[nn];
            }
            for (int nn=0; nn < cDest.Length; nn++)
            {
                cMult[nn++] = cDest[nn];
            }
            return cMult;
        }
        static public eError MyCompare_char(char[]cSrc,char[]cDest)
        {
            if (cSrc ==null || cDest==null)
                return eError.eError_NULL;
            if (cSrc.Length != cDest.Length)
                return eError.eError_BufferSize_NotEqual;
            for(int nn = 0; nn < 4; nn++)
            {
                if (cSrc[nn] != cDest[nn])
                    return eError.eError_Not_Equal;
            }
            return eError.eOK;
        }
        static public char[] MyEraseStr(char[] cSrc,int nctn,int nend)
        {
            char[] cDest = new char[cSrc.Length];
            
            for (int nn = 0; nn < cSrc.Length; nn++)
            {
                if (nn >= nctn && nn < nctn+nend)
                    continue;
                cDest[nn] = cSrc[nn];
            }
            return cDest;
        }
        public static int  MyRecursive(int nInput)
        {
            Console.WriteLine("nInput : {0}",nInput);

            if (nInput <= 0)
                return nInput;
            return MyRecursive (nInput-1);
        }
        public static int MySum(int nNumber)
        {
            //int ni = 0;
            int nRet = 0;
            for (int nn = 1; nn <= nNumber; nn++)
            {
                nRet += nn;
            }
            return nRet;
        }
        public static int RSum(int nInput)
        {
            if (nInput == 0)
                return 0;
            return nInput +RSum(nInput -1);
        }
        static public void Move_Work()
        {
            Console.WriteLine("걷는 중");
        }
        static public void Move_Run()
        {
            Console.WriteLine("달리는 중");
        }
        static public void std_Attck()
        {
            Console.WriteLine("물리공격");
        }
        static public void Magic_Attck1()
        {
            Console.WriteLine("마법공격1");
        }
        static public void Magic_Attck2()
        {
            Console.WriteLine("마법공격2");
        }
    }
}
