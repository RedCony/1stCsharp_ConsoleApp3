using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MyPos
    {
        private int mnPosX;
        private int mnPosY;

        public MyPos() { }

        public MyPos(int nx , int ny)
        {
            mnPosX = nx;
            mnPosY = ny;
        }

        ~MyPos() { Console.WriteLine("MyPos 삭제됨"); }

       public int GetPosX() { return mnPosX; }

       public int GetPosY() { return mnPosY; }

       public void SetPos (int nx , int ny)
        {
            this.mnPosX = nx;
            this.mnPosY = ny;
        }

     

    }
}
