using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci.Get(40));
            Console.WriteLine(Fibonacci.Get(100));

            //캡슐화
            /*Box box = new Box();
            box.Width = 30;
            box.Height = 200;
            Console.WriteLine("너비 : " + box.Width + ", 높이 : " + box.Height);*/
            /*box.SetWidth(10);
            box.SetHeight(200);
            Console.WriteLine("너비 : " + box.GetWidth() + ", 높이 : " + box.GetHeight());*/
            /*Test test = new Test();
            Mart mart = new Mart("감자", 3000);
            Mart mart2 = new Mart("항정살", 25000);
            Mart mart3 = new Mart() { name = "고향만두", price = 5000 };*/
            /*Console.WriteLine("Power = "+test.Power(1, 2));
            Console.WriteLine("Sum = " + test.Sum(1, 10));
            Console.WriteLine("mul = " + test.Mul(1, 10));*/

            /*Console.WriteLine(Mymath.MaxValue(100, 320));
            Console.WriteLine(Mymath.MaxValue(532.5, 12.45));*/

            /*Console.WriteLine(mart.num +" : "+mart.name + " : "+ mart.price) ;
            Console.WriteLine(mart2.num + " : " + mart2.name + " : " + mart2.price);
            Console.WriteLine(mart3.num + " : " + mart3.name + " : " + mart3.price);*/

        }
    }
}

