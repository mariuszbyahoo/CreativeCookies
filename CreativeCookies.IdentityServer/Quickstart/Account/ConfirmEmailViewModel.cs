using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreativeCookies.IdSrv.Quickstart.Account
{
    public class ConfirmEmailViewModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string ReturnUrl { get; set; }

        public string Email { get; set; }
    }
}
