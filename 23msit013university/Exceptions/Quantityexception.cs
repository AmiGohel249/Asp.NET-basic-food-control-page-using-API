using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23msit013university.Exceptions
{
    public class Quantityexception : Exception
    {
        public Quantityexception() : base("Enter Valid Amount of Quantiti , Quantity Must be in between 0 to 10 .") { }
    }
}