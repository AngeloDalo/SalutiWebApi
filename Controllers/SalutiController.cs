using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalutiWebApi2.Controllers
{
    [ApiController]
    [Route("api/saluti")]
    public class SalutiController
    {
        public string getSaluti(){
            return "Saluti, sono la tua prima web api creata in c#";
        }
        [HttpGet("{Nome}")]
        public string getSaluti(String Nome) => string.Format("Saluti, {0} sono il tuo primo web service creato in C# 6.0", Nome);
    }
}