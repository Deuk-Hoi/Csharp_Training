using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class IDisposable_Basic : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose() 메서드를 호출합니다.");
        }
    }
}
