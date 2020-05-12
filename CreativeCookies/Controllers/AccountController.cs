using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreativeCookies.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpGet]
        [Route("signout")]
        public IActionResult SignOut()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}
