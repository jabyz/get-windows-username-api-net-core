using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace get_windows_username_api_net_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        
        [HttpGet]
        //GET : /api/Account
        public JsonResult Get()
        {
            IPrincipal p = HttpContext.User;
            return new JsonResult(new { UserName = p.Identity.Name });
        }
    }
}
