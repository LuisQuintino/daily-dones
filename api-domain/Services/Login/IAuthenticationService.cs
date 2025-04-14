using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_domain.Services.Login
{
    public interface IAuthenticationService
    {
        public string Autenticar(string email, string senha);
    }
}
