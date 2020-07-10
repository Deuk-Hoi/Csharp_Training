using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Advanced
{
    class Indexer
    {
        public int this[int i]
        {
            get
            {
                return i * i;
            }
        }
    }
}
