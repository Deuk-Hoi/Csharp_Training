using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Advanced
{
    class Copy
    {
        class CopyClass
        {
            public int x;
            public int y;

            public CopyClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct CopyStruct
        {
            public int x;
            public int y;

            public CopyStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public void CopyData()
        {
            CopyClass copyClassA = new CopyClass(10, 20);
            CopyClass copyClassB = copyClassA; // 참조복사가 일어난다.

            copyClassB.x = 100;
            copyClassB.y = 200;

            Console.WriteLine("CopyClass A = X : " + copyClassA.x + ", Y: " + copyClassA.y);
            Console.WriteLine("CopyClass A = X : " + copyClassB.x + ", Y: " + copyClassB.y);

            CopyStruct copyStructA = new CopyStruct(10, 20);
            CopyStruct copyStructB = copyStructA; //값 복사가 일어난다.

            copyStructB.x = 100;
            copyStructB.y = 200;

            Console.WriteLine("copyStruct A = X : " + copyStructA.x + ", Y: " + copyStructA.y);
            Console.WriteLine("copyStruct B = X : " + copyStructB.x + ", Y: " + copyStructB.y);
        }
    }
}
