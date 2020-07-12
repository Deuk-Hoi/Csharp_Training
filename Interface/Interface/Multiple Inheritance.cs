using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Parent
    {

    }
    class Multiple_Inheritance : Parent, IComparable, IDisposable //자바와 다르게 implement 없이 여러개의 클래스의 상속이 가능하다.
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
