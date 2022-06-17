using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    internal class SQLDataAccess : IDataAccess
    {


        public List<Product> LoadData()
        {
            Console.WriteLine("Reading from SQL database.");
            List<Product> products = new List<Product>();
            //return (new Product { Name = "List", Price = "10$" });
            return products;
            throw new NotImplementedException();
        }


        public void SaveData()
        {
            {
                Console.WriteLine("Reading from SQL database.");

            }

        }
    }
}
