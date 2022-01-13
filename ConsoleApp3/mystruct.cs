using System;
using System.Runtime.Serialization;                    // IFormatter 인터페이스 사용을 위해 추가
using System.Runtime.Serialization.Formatters.Binary;  // 바이너리 포맷을 위해 추가 
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    [Serializable]
    struct MyScores
    {
        public int nKorPoint;
        public int nEngPoint;
        public int nMathPoint;
    }
    [Serializable]
    struct Humaninfo
    {
        public string mstrNmae;
        public ushort mnAge;
        public ushort mnHeight;
        public eGender meGender;

        public void InitData(string sTrname, ushort snAge, ushort snHeight, eGender gender)
        {
            mstrNmae = sTrname;
            mnAge = snAge;
            mnHeight = snHeight;
            meGender = gender;
        }

    }
}
