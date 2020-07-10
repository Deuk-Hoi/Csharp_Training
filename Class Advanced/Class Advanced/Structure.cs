using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Advanced
{
    class Structure
    {
        struct Point
        {
            public int x;
            public int y; //변수를 만들면 생성자에서 초기화를 만드시 해줘야한다.

            public Point(int x, int y) //구조체는 클래스와 다르게 매개변수가 없는 생성자를 만들지 못한다.
            {
                this.x = x;
                this.y = y;
            }
        }
        public void location()
        {
            Point point;
            point.x = 100; //초기화를 하고 사용을 해야 오류가 나지 않는다.
            point.y = 200;

            Console.WriteLine("Location = X: " + point.x + ", Y: " + point.y);

            Point p = new Point(); //매개변수가 없는 생성자를 만들 수는 없지만 생성은 가능하다. 생성시 default = 0
            Console.WriteLine("Location = X: " + p.x + ", Y: " + p.y);
            Point p2 = new Point(1, 2);
            Console.WriteLine("Location = X: " + p2.x + ", Y: " + p2.y);
        }

    }
}
