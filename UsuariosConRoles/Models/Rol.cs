using Microsoft.AspNetCore.Identity;

namespace UsuariosConRoles.Models
{
    public class Rol: IdentityRole
    {
        public ICollection<UsuarioRol> UsuariosRoles { get; set; }
    }
}
