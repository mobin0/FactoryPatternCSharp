using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    internal class Python : ICallable
    {
        public void Build()
        {
            Console.WriteLine("Building Python Program!");
        }
    }
}
