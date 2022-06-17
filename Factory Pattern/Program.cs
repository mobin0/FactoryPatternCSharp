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
                if (input == "quit") {
                    Console.WriteLine("Thank you for using App Builder!");
                    break;
                }
                ICallable App = AppFactory.GetApp(input);
                if (App is null) {
                    Console.WriteLine($"{input} App type is not supported right now");
                    continue;
                }
                Console.WriteLine("");
                App.Build();
                Console.WriteLine("");
                Console.WriteLine("What Type of Database would you like?");
                IDataAccess data = DataAccessFactory.GetDataAccessType(Console.ReadLine());
                if (data is null)
                {
                    Console.WriteLine($"{input} database type is not supported right now");
                    continue;
                }
                data.SaveData();
                data.LoadData();
                Console.WriteLine("");
            }
       }
    }
}
