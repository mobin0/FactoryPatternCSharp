using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    internal interface IDataAccess
    {

        List<Product> LoadData();
        void SaveData();


    }
}
