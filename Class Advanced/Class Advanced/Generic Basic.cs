using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Advanced
{
    class Generic_Basic<T>
    {
        public T Value;

        public Generic_Basic(T value)
        {
            this.Value = value;
        }
    }

    class Two_Generic<T, U>
    {
        public T Value;
        public U User;

        public Two_Generic(T value, U user)
        {
            this.Value = value;
            this.User = user;
        }
    }
}
