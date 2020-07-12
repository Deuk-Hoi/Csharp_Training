using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception_Basic();
            //Exception_Advanced();
            //Exception_classify();
            //Forced_Exception();
            Custom_Exception();
        }
        public static void Exception_Basic() //if else로 예외를 처리하는 방법 기본 예외 처리
        {
            string[] name = { "김득회", "득회", "득득" };
            Console.Write("숫자를 입력 하시오: ");
            int num = int.Parse(Console.ReadLine());
            if(num < name.Length)
            {
                Console.WriteLine("입력한 위치의 값은 " + name[num] + " 입니다.");
            }
            else
            {
                Console.WriteLine("인덱스 범위를 넘었습니다.");
            }
            
        }
        public static void Exception_Advanced()//try catch finally로 예외를 처리하는 고급 예외 처리
        {
            Console.Write("숫자를 입력하시오 : ");
            string n = Console.ReadLine();

            try
            {
                int num = int.Parse(n);
                Console.WriteLine("입력하신 숫자는 " + num + " 입니다.");
            }
            catch(Exception e)
            {
                Console.WriteLine("예외가 발생했습니다.");
                Console.WriteLine("예외 종류 : " + e.GetType());
                Console.WriteLine("예외 종류 : " + e.Message);
                Console.WriteLine("예외 종류 : " + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
        public static void Exception_classify()//예외가 2개 이상 발생할 수 있는 경우 구분하여 다른 처리를 하기 위해 사용
        {
            string[] food = { "피자", "치킨", "삼겹살", "떡볶이" };
            Console.Write("숫자를 입력하시오: ");
            
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(food[num] + "을 선택하였습니다.");
            }
            catch(FormatException e)
            {
                Console.WriteLine("FormatException 발생");
                Console.WriteLine(e.GetType() + "발생");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException 발생");
                Console.WriteLine(e.GetType());
            }
            finally
            {
                Console.WriteLine("프로그램을 종료 합니다.");
            }

        }
        public static void Forced_Exception()
        {
            Box box = new Box(10, -20);
            Console.WriteLine("너비: "+box.Width+" 높이: "+box.Height);
            Console.WriteLine("박스의 넓이 = "+ box.Area());
        }
        public static void Custom_Exception()
        {
            try
            {
                throw new Custom_Exception("사용자 예외 처리");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
