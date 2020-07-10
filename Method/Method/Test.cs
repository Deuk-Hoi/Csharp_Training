using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    class Test
    {
        public int Power(int x, int y)
        {
            return x + y;
        }
        public int Sum(int min, int max)
        {
            int output = 0;
            for (int i = min; i <= max; i++)
            {
                output += i;
            }
            return output;
        }
        public int Mul(int min, int max)
        {
            int output = 1;
            for(int i = min; i <= max; i++)
            {
                output *= i;
            }
            return output;
        }
    }
    class Mymath
    {
        public static int MaxValue(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
        public static double MaxValue(double x, double y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
    }
    class Mart
    {
        public static int count = 0;
        public int num;
        public string name;
        public int price;

        public Mart()
        {
            Mart.count = count + 1;
            this.num = count;
        }
        public Mart(String name, int price)
        {
            Mart.count = count + 1;
            this.num = count;
            this.name = name;
            this.price = price;
        }

    }
    class Box
    {
        private int width;
        private int height;

       /* // getter
        public int GetWidth(){return this.width;}
        public int GetHeight(){return this.height;}
        // setter
        public void SetWidth(int width)
        {
            if (width > 0)
                this.width = width;
            else
                Console.WriteLine("너비는 자연수로 초기화 해주세요.");
        }
        public void SetHeight(int height)
        {
            if (width > 0)
                this.height = height;
            else
                Console.WriteLine("높이는 자연수로 초기화 해주세요.");
        }*/

        public int Width
        {
            get { return this.width;  }
            set
            {
                if (value > 0)
                    this.width = value;
                else
                    Console.WriteLine("너비는 자연수로 초기화 해주세요.");
            }
        }
        public int Height
        {
            get { return this.height; }
            set
            {
                if (value > 0)
                    this.height = value;
                else
                    Console.WriteLine("높이는 자연수로 초기화 해주세요.");
            }
        }
    }
    class Fibonacci
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        /*public static long Get (int i)
        {
            if(i < 0) { return 0; }
            if(i == 0) { return 1; }
            if(i == 2) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }*/
        public static long Get (int i)
        {
            if(i < 0) { return 0; }
            if(i == 1) { return 1; }
            if(i == 2) { return 1; }

            if(memo.ContainsKey(i))
            {
                return memo[i];
            }
            else
            {
                long value = Get(i - 2) + Get(i - 1);
                memo[i] = value;
                return value;
            }
        }
    }
}
