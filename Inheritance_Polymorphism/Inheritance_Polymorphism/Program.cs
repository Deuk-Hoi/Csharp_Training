using System;
using System.Collections.Generic;

namespace Inheritance_Polymorphism
{
    class Program
    {
        public static int number = 10;
        static void Main(string[] args)
        {
            //NoInheritance();
            //Inheritance();
            //Polymorphism();
            //Shadowing();
            //hiding();
            //Method_Hiding();
            Override_Trainnig();
        }

        public static void NoInheritance()
        {
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
        public static void Inheritance()
        {
            Dog1 dog1 = new Dog1();
            Cat1 cat1 = new Cat1();
            dog1.Test();
            cat1.Test();
        }
        public static void Access_control()
        {
            Access_control ac = new Access_control();
            //ac.Private();
            //ac.Protected(); => private는 내부 클래스에서만 사용이 가능하고 protected는 내부 클래스와 상속된 파생 클래스에서만 접근이 가능하다.
            ac.Public(); //어디에서나 사용이 가능하다.
        }
        public static void Polymorphism()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog1(), new Cat1(), new Cat1(),
                new Dog1(), new Dog1()
            };

            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();
                //((Cat1)item).Meow(); //Dog 객체에는 없는 함수이기 때문에 문제 발생

                /*if (item is Dog1) { ((Dog1)item).Bark(); }
                if (item is Cat1) { ((Cat1)item).Meow(); }*/
                
            }
            Use_as(animals);
        }
        public static void Use_as(List<Animal> animals)
        {
            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();

                var dog = item as Dog1;
                var cat = item as Cat1;
                if(dog != null)
                {
                    dog.Bark();
                }
                if(cat != null)
                {
                    cat.Meow();
                }
            }
        }
        public static void Shadowing()
        {
            int number = 30;
            Console.WriteLine(number);
        }
        public static void hiding()
        {
            Child child = new Child();
            Console.WriteLine(child.variable); //자식 클래스에 가려져 원래의 값이 나오지 않는다.
            Console.WriteLine(((Parent)child).variable); // 부모클래스의 값을 보고 싶으면 자료형을 변환하고 사용을 하면 된다.
        }
        public static void Method_Hiding()
        {
            Child child = new Child();
            Console.WriteLine(child.variable);
            child.Method(); //변수와 마찬가지로 같은 이름의 메서드를 사용하게 되면 부모클래스의 메서드가 가려지게 된다.
            ((Parent)child).Method(); //부모클래스의 메서드를 호출하고 싶을 경우에는 자료형 변환을 사용하면 된다.

            /*child.Method2();
            ((Parent)child).Method2();*/
        }
        public static void Override_Trainnig()
        {
            List<Animal2> animal2 = new List<Animal2>()
            {
                new Dog2(), new Cat2(), new Dog2(),
                new Dog2(), new Cat2(), new Cat2()
            };

            foreach(var item in animal2)
            {
                item.Eat();
            }
        }

        public static void Abstract()
        {
            //Parent1 parent1 = new Parent1(); // 오류 발생 abstract로 선언된 클래스는 인스턴스 변수를 생성할 수 없다.
        }

    }

}