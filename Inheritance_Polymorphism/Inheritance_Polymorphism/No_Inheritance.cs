using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Polymorphism
{
    class No_Inheritance
    {
    }
    class Dog
    {
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog() { this.Age = 0; }
        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
    }

    class Cat
    {
        public int Age { get; set; }

        public Cat() { this.Age = 0; }
        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }
}
