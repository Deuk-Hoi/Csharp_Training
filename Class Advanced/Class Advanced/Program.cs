using System;

namespace Class_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic_basic();
            //Indexer();
            //OutKeyword();
            Structure();
        }
        public static void Generic_basic()
        {
            Generic_Basic<string> generic_string = new Generic_Basic<string>("String");
            Generic_Basic<int> generic_int = new Generic_Basic<int>(8);
            Generic_Basic<double> generic_double = new Generic_Basic<double>(3.14);

            Two_Generic<int, String> two_ex1 = new Two_Generic<int, string>(5, "hello");

            Console.WriteLine(generic_string.Value);
            Console.WriteLine(generic_int.Value);
            Console.WriteLine(generic_double.Value);
            Console.WriteLine(two_ex1.Value + " " + two_ex1.User);
        }
        public static void Indexer()
        {
            Indexer indexer = new Indexer();

            Console.WriteLine(indexer[10]);
        }
        public static void OutKeyword()
        {
            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;

            OutKeyword outKeyword = new OutKeyword();
            outKeyword.Out_basic();
            outKeyword.Two_out(x, y, vx, vy, out x, out y); //2개 이상을 반환 할 수 있다.

            Console.WriteLine("다음 좌표 = X : " + x + ", Y: " + y);
        }
        public static void Structure()
        {
            /*Structure structure = new Structure();
            structure.location();*/
            Copy copy = new Copy();
            copy.CopyData();
        }
    }    
}
