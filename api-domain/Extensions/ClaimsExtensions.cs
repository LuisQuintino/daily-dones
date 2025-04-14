using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using api_domain.Entidades;

namespace api_domain.Extensions
{
    public static class ClaimsExtensions
    {
        public static IEnumerable<Claim> ObterClaims(this Usuario usuario)
            => new List<Claim>
            {
                new(ClaimTypes.Email, usuario.Email),
                new("CodigoUsuario", usuario.Codigo.ToString())

            };
    }
}
