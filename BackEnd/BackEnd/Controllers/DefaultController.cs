using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DefaultController : ControllerBase
    { // GET: api/<DefaultController>
        [HttpGet]

        public string Get ()
            {
            return "Aplicacion Corriendo";
        
        
        }



    }





}

