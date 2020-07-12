using System;
using System.Collections.Generic;
using System.IO;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Icomparable_Basic();
            //IDisposable_Basic();
            //Interface();
            //Application_example();
            streamWriter();
        }
        public static void Icomparable_Basic()
        {
            List<Icomparable_Basic> list = new List<Icomparable_Basic>()
            {
                new Icomparable_Basic(){Name = "고구마", Price = 1500},
                new Icomparable_Basic(){Name = "사과", Price = 2400},
                new Icomparable_Basic(){Name = "포도", Price = 5000},
                new Icomparable_Basic(){Name = "딸기", Price = 6500}
            };

            list.Sort();

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void IDisposable_Basic()
        {
            IDisposable_Basic disposable_Basic = new IDisposable_Basic();
            disposable_Basic.Dispose();

            using(IDisposable_Basic disposable_Basic2 = new IDisposable_Basic())
            {
                //자동으로 Dispose 메서드가 호출이된다.
            }
        }
        public static void Interface()
        {
            Interface interfaces = new GetInterface();
            Console.WriteLine(interfaces.TestInterface());
        }
        public static void Multiple_Inherutance()
        {
            Multiple_Inheritance multiple_Inheritance = new Multiple_Inheritance();
            Parent parent = new Multiple_Inheritance();
            IComparable comparable = new Multiple_Inheritance();
            IDisposable disposable = new Multiple_Inheritance();
            //다형성있는 코드를 구현할 수 있다.
        }
        public static void Application_example()
        {
            Application_example application_Example = new Application_example();
            application_Example.WriteReadFile();
        }
        public static void streamWriter()
        {
            using(StreamWriter Writer = new StreamWriter(@"D:\C# Programming Trainnig\Test.txt"))
            {
                Writer.WriteLine("안녕하세요");
                Writer.WriteLine("저는 김득회입니다.");
                Writer.WriteLine("반갑습니다.");

                for(int i = 0; i<15; i++)
                {
                    Writer.WriteLine("반복을 합니다. = " + i);
                }
            }
            //Console.WriteLine(File.ReadAllText(@"D:\C# Programming Trainnig\Test.txt")); //한번에 읽는 방법

            using (StreamReader reader = new StreamReader(@"D:\C# Programming Trainnig\Test.txt")) //한줄씩 읽는 방법
            {
                string line;
                while((line = reader.ReadLine())!= null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }


}
