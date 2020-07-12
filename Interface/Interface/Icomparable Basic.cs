using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Icomparable_Basic : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj) //sort를 할 때는 반드시 CompareTo를 선언 해야한다.
        {
            return this.Price.CompareTo((obj as Icomparable_Basic).Price);
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }
    }
}
