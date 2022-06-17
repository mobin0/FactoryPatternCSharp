using System;
using System.Collections.Generic;
using System.Text;


namespace Factory_Pattern
{
    internal class MongoDataAccess : IDataAccess
    {
        
        public List<Product> LoadData()
        {
            Console.WriteLine("Reading from mongo database.");
            List<Product> products = new List<Product>();
            //return (new Product { Name = "Mongo", Price = "3$" });
            return products;
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            Console.WriteLine("Saving to list database.");
            //return new Product("List", "5$");

        }
    }
}
