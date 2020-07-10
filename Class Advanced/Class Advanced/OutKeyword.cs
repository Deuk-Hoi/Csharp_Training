using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Advanced
{
    class OutKeyword
    {
        public void Out_basic()
        {
            Console.WriteLine("숫자를 입력");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);

            if(result)
            {
                Console.WriteLine("입력한 숫자 : " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요~");
            }
        }
        public void Two_out(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
    }
}
