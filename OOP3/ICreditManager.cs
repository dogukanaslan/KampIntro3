using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager
    {
        void Calculate();
        void DoSomething();
    }
}

//İmzanın(Calculate) aynı olduğu ama içerisinin farkli olduğu durumlarda basede oluşturduğumuz classı class olarak değil de interface olarak alırız.
