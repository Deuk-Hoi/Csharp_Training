using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Interface
{
    class Application_example
    {
        public void WriteReadFile()
        {
            File.WriteAllText(@"D:\C# Programming Trainnig\Test.txt", "저는 김득회 입니다.", Encoding.UTF8);
            Console.WriteLine(File.ReadAllText(@"D:\C# Programming Trainnig\Test.txt"));
        }
    }
}
