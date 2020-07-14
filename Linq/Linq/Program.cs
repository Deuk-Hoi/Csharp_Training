using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq
{
class Program
    {
    static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //select_from(input);
            //where(input);
            //Orderby(input);
            //AnonymousObject(input);
            //Use_Linq();
            //LoadXml();
            //AnomymousXml();
            ClassXml();

        }
        public static void select_from(List<int> input)
        {
            var output = from item in input
                         select item * item;

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
        public static void where(List<int> input)
        {
            var output = from item in input
                         where (item > 5) && (item % 2 == 0)
                         select item;
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
        public static void Orderby(List<int> list)
        {
            var output = from item in list
                         where (item > 5) && (item % 2 == 0)
                         orderby item descending //ascending(오름차순)
                         select item;

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
        public static void AnonymousObject(List<int> list)
        {
            var output = from item in list
                         where item % 2 == 0
                         select new
                         {
                             A = item * 2,
                             B = item * item,
                             C = 100
                         };
            foreach (var item in output)
            {
                Console.WriteLine(item.A);
                Console.WriteLine(item.B);
                Console.WriteLine(item.C);
                Console.WriteLine();
            }
        }
        public static void Use_Linq()
        {
            List<Product> list = new List<Product>()
            {
                new Product() {Name = "불고기 버거", Price = 3200},
                new Product() {Name = "핫 크리스피 버거", Price = 4500},
                new Product() {Name = "빅맥", Price = 5400},
                new Product() {Name = "치즈버거", Price = 3500},
                new Product() {Name = "후렌치 후라이", Price = 1500},
                new Product() {Name = "사과파이", Price = 1000}
            };

            var output = from item in list
                         where item.Price > 1500
                         orderby item.Name ascending
                         select item;

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
        public static void LoadXml()
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url); //xml 로드 하는 코드
            var xmlQuery = from item in xElement.Descendants("data") //xml 태그를 찾아서 분리하는 코드
                           select item;
            foreach (var item in xmlQuery)
            {
                Console.Write(item.Element("hour").Value + "\t");
                Console.Write(item.Element("day").Value + "\t");
                Console.Write(item.Element("temp").Value + "\t");
                Console.Write(item.Element("wdKor").Value + "\t");
                Console.Write(item.Element("wfKor").Value + "\t");
                Console.Write(item.Element("tmn").Value + "\t");
                Console.WriteLine(item.Element("tmx").Value + "\t");
            }
        }
        public static void AnomymousXml()
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);
            var xmlQuery = from item in xElement.Descendants("data")
                           select new
                           {
                               Hour = item.Element("hour").Value,
                               Day = item.Element("day").Value,
                               Temp = item.Element("temp").Value,
                               WdKor = item.Element("wdKor").Value,
                               WfKor = item.Element("wfKor").Value,
                               Tmn = item.Element("tmn").Value,
                               Tmx = item.Element("tmx").Value
                           };

            foreach (var item in xmlQuery)
            {
                Console.Write(item.Hour + "\t");
                Console.Write(item.Day + "\t");
                Console.Write(item.Temp + "\t");
                Console.Write(item.WdKor + "\t");
                Console.Write(item.WfKor + "\t");
                Console.Write(item.Tmn + "\t");
                Console.WriteLine(item.Tmx + "\t");
            }

        }
        public static void ClassXml()
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);
            var xmlQuery = from item in xElement.Descendants("data")
                           select new Weather()
                           {
                               Hour = item.Element("hour").Value,
                               Day = item.Element("day").Value,
                               Temp = item.Element("temp").Value,
                               WdKor = item.Element("wdKor").Value,
                               WfKor = item.Element("wfKor").Value,
                               Tmn = item.Element("tmn").Value,
                               Tmx = item.Element("tmx").Value
                           };

            foreach (var item in xmlQuery)
            {
                Console.Write(item.Hour + "\t");
                Console.Write(item.Day + "\t");
                Console.Write(item.Temp + "\t");
                Console.Write(item.WdKor + "\t");
                Console.Write(item.WfKor + "\t");
                Console.Write(item.Tmn + "\t");
                Console.WriteLine(item.Tmx + "\t");
            }
        }
    }
}
