using System;

namespace Test
{
    class Program
    {
        /*static int Abs(int input)
        {
            return input > 0 ? input : -input; 
        }
        static double Abs(int input)
        {
            return input > 0 ? input : -input;
        }
        static long Abs(long input)
        {
            return input > 0 ? input : -input;
        }*/

        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child c = new Child();
            Console.WriteLine(c.Question());
            Child a = (Child)p;

        }
    }
    class Parent
    {
        public virtual int Question()
        {
            return 10;
        }
    }
    class Child : Parent
    {
        public override int Question()
        {
            return 20;
        }
    }
}
