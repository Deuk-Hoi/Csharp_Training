using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Polymorphism
{
    class Shadowing_Hiding
    {

    }
    class Parent
    {
        public int variable = 200;
        public void Method()
        {
            Console.WriteLine("부모클래스 메서드");
        }

        public virtual void Method2() //오버라이딩 대상의 부모 클래스는 virtual로 선언한다.
        {
            Console.WriteLine("부모클래스 메서드");
        }
    }

    class Child : Parent
    {
        public new string variable = "shadowing"; //new 키워드를 사용하여 같은 이름으로 멤버를 만들어 부모의 멤버를 숨기겠다, 하이딩을 하겠다고 선언한다.
        public new void Method()
        {
            Console.WriteLine("자식클래스 메서드");
        }

        public override void Method2() //override 대상의 자식 클래스는 override로 선언을 한다. (오버라이딩은 부모의 메서드를 덮어 씌운다라고 생각하면 된다.)
        {
            Console.WriteLine("자식클래스 메서드");
        }
    }

    class Animal2
    {
        public virtual void Eat() //자바에서는 오버라이딩 대상을 지정을 하지 않았지만 C#에서는 오버라이딩이 되는 주체와 오버라이딩 대상을 지정해주어야 한다.
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
    }

    class Dog2 : Animal2
    {
        public override void Eat()
        {
            Console.WriteLine("강아지 사료를 먹습니다.");
        }
    }

    class Cat2 : Animal2
    {
        public override void Eat()
        {
            Console.WriteLine("고양이 사료를 먹습니다.");
        }
    }
}