using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Polymorphism
{
    class Inheritance
    {
    }
    class Animal
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
    }

    class Dog1 : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }

        public void Test()
        {
            Eat();
            Sleep();
        }
    }
    class Cat1 : Animal
    {
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        public void Test()
        {
            Eat();
            Sleep();
        }
    }
}
