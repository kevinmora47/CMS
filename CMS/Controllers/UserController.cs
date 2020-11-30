using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("permit")]
    public class UserController : ControllerBase
    {   
        [HttpPost]
        public ActionResult validateSesion(Models.Users user)
        {
            return null;
        }
    }
}
