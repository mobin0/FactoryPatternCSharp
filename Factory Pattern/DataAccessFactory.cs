using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    internal static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string dataType)
        {
            IDataAccess database;
            switch (dataType.ToLower())
            {
                case "list":
                    database = new ListDataAccess();
                    break;
                case "mongo":
                case "mongodb":
                    database = new MongoDataAccess();
                    break;
                case "sql":
                    database = new SQLDataAccess();
                    break;
                default:
                    database = null;
                    break;

            }
            return database;
        }
    }
}
