using api_domain.Repositories.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace daily_dones_api.Controllers.Base
{
    public abstract class ControllerBaseV2 : ControllerBase
    {

        protected Guid ObterCodigoUsuario()
        {
            var codigoUsuario = HttpContext.User.Claims
                .FirstOrDefault(x => x.Type == "CodigoUsuario")?.Value;

            if (string.IsNullOrEmpty(codigoUsuario))
                throw new Exception("Código do usuário não encontrado.");

            return Guid.Parse(codigoUsuario);
        }
    }
}
