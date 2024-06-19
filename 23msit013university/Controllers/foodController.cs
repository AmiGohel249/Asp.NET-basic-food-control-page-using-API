//using Microsoft.AspNetCore.Cors;
using _23msit013university.Exceptions;
using _23msit013university.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Http.Cors;



namespace _23msit013university.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class foodController : ApiController
    {
        FOODDBEntities1 contex = new FOODDBEntities1();
        [HttpGet]
        public List<TBLFood> showdata()
        {
            return contex.TBLFoods.ToList();

        }
        public object PostAddEmpDetails(TBLFood result)
        {
            try
            {
                if (result.Quantity < 0 || result.Quantity > 10)
                {
                    throw new Quantityexception();

                }
                var a = contex.TBLFoods.ToList();

                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i].Name.Equals(result.Name))
                    {
                        throw new itemAlredyexistexception();
                    }
                }
                result.Name += '1'; // append one if name of food is same as listed items name.
                contex.TBLFoods.Add(result);
                contex.SaveChanges();
                return new { output = true, message = "" };
            }
            catch (Quantityexception ex)
            {
                return new { output = false, message = ex.Message };
            }
            catch (itemAlredyexistexception ex)
            {
                return new { output = false, message = ex.Message };
            }
        }

    }
}