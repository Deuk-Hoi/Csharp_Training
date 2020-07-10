using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Firstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.callMethod();
        }

        public void otherClassCall()
        {
            Product p = new Product() { name = "감자", price = 2000 }; //자바에서는 인스턴스에 초기값을 부여 하려면 매개변수가 있는 생성자를 만들어야했는데 C#은 필요없다.
            /*p.name = "감자";
            p.price = 3000;*/

            Console.WriteLine(p.name + " : " + p.price + " 원 " + ", 특징 : " + Product.feature); //클래스변수를 사용하면 인스턴스를 따로 만들지 않아도 된다. static을 사용한다.

        }
        public void callCar()
        {
            //Car[] car = new Car[10]; //같은 변수를 클래스안에 생성하여 배열로 생성자를 만들면 변수가 여러개 생기는것을 방지할 수 있다.
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();
        }
        public void trainRandom()//이미 만들어진 클래스 호출
        {
            Random r = new Random();
            Console.WriteLine(r.Next(10, 100));
            Console.WriteLine(r.Next(20, 30));
            Console.WriteLine(r.Next(400, 1000));
            Console.WriteLine(r.Next(10));
            Console.WriteLine(r.NextDouble()); //NextDouble은 0.0 ~ 1.0 사이의 난수를 반환한다.
        }
        public void trainList()
        {
            List<int> list = new List<int>(); //가변 배열이라고 생각을 하면 될 듯하다.
            list.Add(100);
            list.Add(30);
            list.Add(4);

            Console.WriteLine(list.Count()+"\n"); //리스트안의 개수를 파악할 때 사용

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            list.Remove(30); // 요소 제거
            list.Remove(list[0]); //특정 인덱스 제거

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }
        public void trainMath()
        {
            Console.WriteLine(Math.Abs(-434324)); //절대값
            Console.WriteLine(Math.Ceiling(52.4534)); //최대 정수로 반환
            Console.WriteLine(Math.Floor(52.4534)); //최소 정수로 반환
            Console.WriteLine(Math.Max(3, 10)); //최댓값
            Console.WriteLine(Math.Min(3, 10)); //최솟값
            Console.WriteLine(Math.Round(45.3)); //반올림
            Console.WriteLine(Math.Round(45.6)); //반올림
            Console.WriteLine(Math.PI); //원주율
        }
        public void student()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "김득회", grade = 3 });
            list.Add(new Student() { name = "득회", grade = 4 });
            list.Add(new Student() { name = "김", grade = 1 });
            list.Add(new Student() { name = "득", grade = 2 });
            list.Add(new Student() { name = "회", grade = 3 });

            foreach (var i in list)
            {
                Console.WriteLine(i.name + " : " + i.grade);
            }

            Console.WriteLine("\nfor 사용");
           
            for(int i =0; i<list.Count;i++) // 오류 : 다른것을 지워 버린다.
            {
                if(list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }
            /**foreach (var i in list) //오류 : foreach를 사용하면 내부에서 반복되는 리스트는 추가 제거가 불가능하다
           {
               if(i.grade > 1)
               {
                   list.Remove(i);
               }
           }*/

            /*for(int i = list.Count - 1; i >=0; i--) //역 for 문을 사용하면 잘 된다.
            {
                if (list[i].grade > 1)
                    list.RemoveAt(i);
            }*/

            foreach (var i in list)
            {
                Console.WriteLine(i.name + " : " + i.grade);
            }

            /*List<Student> list2 = new List<Student>()
            {
                new Student(){name = "김", grade = 1},
                new Student(){name = "득", grade = 2},
                new Student(){name = "회", grade = 3}
            };

            foreach (var i in list2)
            {
                Console.WriteLine(i.name + " : " + i.grade);
            }*/

        }
        public void callMethod()
        {
            //callCar();
            //trainRandom();
            //trainList();
            //trainMath();
            //otherClassCall();
            //student();
        }
    }
}


