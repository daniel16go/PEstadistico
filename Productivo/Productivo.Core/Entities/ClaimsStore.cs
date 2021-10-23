using System.Collections.Generic;
using System.Security.Claims;

namespace Productivo.Core.Entities
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
            new Claim("Crear Rol", "Crear Rol"),
            new Claim("Actualizar Rol", "Actualizar Rol"),
            new Claim("Eliminar Rol", "Eliminar Rol")
        };
    }
}
