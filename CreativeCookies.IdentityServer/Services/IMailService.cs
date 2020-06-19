using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreativeCookies.IdSrv.Services
{
    public interface IMailService
    {
        Task SendConfirmationToken(string receiverAddress, string receiverLogin, string activationLink);
    }
}
