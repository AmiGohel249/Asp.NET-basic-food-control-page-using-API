using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23msit013university.Exceptions
{
    public class itemAlredyexistexception : Exception
    {
        public itemAlredyexistexception() : base("Item is Alredy Exist.") { }
    }
}