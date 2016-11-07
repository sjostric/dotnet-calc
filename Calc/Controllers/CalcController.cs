using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calc.Controlleris
{
    [Route("api/[controller]")]
    public class CalcController : Controller
    {
        [HttpGet("add/{a}/{b}")]
        public string addition(int a, int b)
        {
            return (a+b).ToString();
        }

        [HttpGet("sub/{a}/{b}")]
        public string subtraction(int a, int b)
        {
            return (a-b).ToString();
        }

       
    }
}
