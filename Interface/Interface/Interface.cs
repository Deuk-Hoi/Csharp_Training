using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface Interface
    {
        int TestInterface();
        int TestVariable { get; set; }
    }

    class GetInterface : Interface
    {
        public int TestVariable
        { get => throw new NotImplementedException(); 
          set => throw new NotImplementedException(); 
        }

        public int TestInterface()
        {
            return 1;
        }
    }
}