using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class CSharp: ICallable
    {
        public void Build() {
            Console.WriteLine("Building C# Program!");
        }
    }
}
