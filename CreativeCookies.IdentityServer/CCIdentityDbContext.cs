using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreativeCookies.IdentityServer
{
    public class CCIdentityDbContext: IdentityDbContext
    {
        public CCIdentityDbContext(DbContextOptions<CCIdentityDbContext> options) : base(options)
        {

        }
    }
}
