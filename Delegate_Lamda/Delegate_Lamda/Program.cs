using System;
using System.Collections.Generic;
using System.Threading;

namespace Delegate_Lamda
{
    public delegate void TestDelegateA(); //클래스 밖에서도 선언 가능
    class Program
    {
        public delegate void TestDelegateB(); //클래스 안에서도 선언 가능
        public delegate void InitDelegate();
        public delegate void SendString(string message);
        static void Main(string[] args)
        {
            //Delegate_Basic();
            //Delegate_Basic_UnNamedDelegete();
            //Lamda_Basic();
            //Use_Delegate();
            //AddSub_Delegate();
            Thread_Basic();
        }
        public static void Delegate_Basic()
        {
            List<Product> list = new List<Product>()
            {
                new Product(){Name = "앙파", Price = 3000},
                new Product(){Name = "당근", Price = 1500},
                new Product(){Name = "오이", Price = 2000},
                new Product(){Name = "파프리카", Price = 500}
            };
            list.Sort(SortPrice);
            foreach(var item in list)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

            static int SortPrice(Product a, Product b)
            {
                return a.Price.CompareTo(b.Price);
            }
        }
        public static void Delegate_Basic_UnNamedDelegete()
        {
            List<Product> list = new List<Product>()
            {
                new Product(){Name = "앙파", Price = 3000},
                new Product(){Name = "당근", Price = 1500},
                new Product(){Name = "오이", Price = 2000},
                new Product(){Name = "파프리카", Price = 500}
            };
            list.Sort(delegate (Product a, Product b) { return a.Price.CompareTo(b.Price); });
            foreach(var item in list)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }
        }
        public static void Lamda_Basic()
        {
            List<Product> list = new List<Product>()
            {
                new Product(){Name = "앙파", Price = 3000},
                new Product(){Name = "당근", Price = 1500},
                new Product(){Name = "오이", Price = 2000},
                new Product(){Name = "파프리카", Price = 500}
            };

            //list.Sort((a, b) => { return a.Price.CompareTo(b.Price); }); //간단하게 =>를 할용하여 생성
            list.Sort((a, b) => a.Price.CompareTo(b.Price)); //더 간단하게 사용도 가능 : 처리 할 것이 한 줄일 때 가능

            foreach (var item in list)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }
        }
        public static void Delegate_Call()
        {
            TestDelegateA testDelegateA;
            TestDelegateB testDelegateB;
        }
        public static void InitDelegate_sol()
        {
            InitDelegate initDelegateA = TestMethod;
            InitDelegate initDelegateB = delegate () { }; //기본 델리게이트 형식
            InitDelegate initDelegateC = () => { };//람다를 활용한 간편한 델리게이트 사용

            initDelegateA(); //일반 메서드처럼 호출이 가능하다.
            initDelegateB();
            initDelegateC();

            static void TestMethod()
            {

            }

        }
        public static void Use_Delegate()
        {
            Students students = new Students();
            students.Add(new Student("김득회", 4.4));
            students.Add(new Student("고길동", 2.5));

            students.Print();
            students.Print((student) => 
            {
                Console.WriteLine();
                Console.WriteLine("이름 : " + student.Name);
                Console.WriteLine("학점 : " + student.Score);
            });
        }
        public static void AddSub_Delegate()
        {
            SendString MultiDelegate, sayHello, sayGoodbye;

            sayHello = hello;
            sayGoodbye = goodbye;

            MultiDelegate = sayHello + sayGoodbye;
            MultiDelegate("김득회");
            Console.WriteLine();
            MultiDelegate -= sayGoodbye;
            MultiDelegate("김득회");

            void hello(string message)
            {
                Console.WriteLine("안녕하세요. " + message + " 님");
            }
            void goodbye(string message)
            {
                Console.WriteLine("안녕히가세요. " + message + " 님");
            }
        }
        public static void Thread_Basic()
        {
            Thread threadA = new Thread(()=>
            {
                for(int i = 0; i<100; i++)
                {
                    Console.Write("A");
                }
            });

            Thread threadB = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("B");
                }
            });

            Thread threadC = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("C");
                }
            });
            threadA.Start();
            threadB.Start();
            threadC.Start();
        }
        

    }
}
