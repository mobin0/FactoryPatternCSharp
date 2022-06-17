using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    internal class JS: ICallable
    {
        public void Build(){
            Console.WriteLine("Building JavaScript App!");
        }

    }
}
