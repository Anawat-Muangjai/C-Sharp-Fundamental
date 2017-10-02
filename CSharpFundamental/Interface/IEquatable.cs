using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    interface IEquatable<T>
    {
        bool Equals(T obj);

        string Start();
        string Stop();
    }
}
