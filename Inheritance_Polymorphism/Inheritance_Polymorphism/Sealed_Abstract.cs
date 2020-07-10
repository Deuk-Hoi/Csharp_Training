using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Polymorphism
{
    class Sealed_Abstract
    {
    }

    // class sealed

    /*sealed class Parent1 // 부모 클래스는 sealed를 사용하는 순간 상속을 할 수 가 없게 된다.
    {
        public void Test() { }
    }

    class Child2 : Parent1 //오류 발생
    {

    }*/
    
    // 메서드 sealed

    /*class Parent1
    {
        public virtual void Test() { }
    }

    class Child2 : Parent1 
    {
        sealed public override void Test() { }
    }

    class GrandChide : Child2
    {
        public override void Test() { } //Child2의  Test 메서드의 상속을 제한 했기 때문에 불가하다.
    }*/

    // abstract

    abstract class Parent1
    {
        public abstract void Test();//abstract로 추상화가 되면 메서드 전체를 생성할 수 없다 이름만 제시 할 수 있다.
    }

    class Child2 : Parent1 //abstract로 추상화된 클래스를 상속한 자식 클래스는 부모클래스안에 추상화된 메서드가 있을시 반드시 그 메서드를 구현해야한다.
    {
        public override void Test() { } //override로 구현을 하면 된다. 부모 클래스에 virtual을 사용하지 않는 이유는 반드시 상속 되야 하기 때문이다.
    }
}
