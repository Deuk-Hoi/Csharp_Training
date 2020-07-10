using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Inheritance_Polymorphism
{
    class Access_control
    {
        private void Private() { }
        protected void Protected() { }
        public void Public() { }

        public void TestA() // 내부 클래스에서는 모든 접근 제한자 사용이 가능하다.
        {
            Private();
            Protected();
            Public();
        }
    }

    class Inherutance : Access_control
    {
        public void TestB()
        {
            //Private(); => private 접근제한자는 내부 클래스에서만 사용이 가능하기 때문에 상속한 파생 클래스에서는 사용이 불가능 하다.
            Protected();
            Public();
        }
    }
}
class Access_control
{
    private void Private() { }
    protected void Protected() { }
    public void Public() { }

    public void TestA() // 내부 클래스에서는 모든 접근 제한자 사용이 가능하다.
    {
        Private();
        Protected();
        Public();
    }
}

class Inherutance : Access_control
{
    public void TestB()
    {
        //Private(); => private 접근제한자는 내부 클래스에서만 사용이 가능하기 때문에 상속한 파생 클래스에서는 사용이 불가능 하다.
        Protected();
        Public();
    }
}