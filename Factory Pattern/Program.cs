using System;

namespace Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What type of App do you want to Create?");
                string input = Console.ReadLine();
                ICallable App = AppFactory.GetApp(input);
                if (App is null) {
                    Console.WriteLine($"{input} App type is not supported right now");
                    continue;
                }
                Console.WriteLine("");
                App.Build();
            }
       }
    }
}
