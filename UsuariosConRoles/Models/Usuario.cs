using Microsoft.AspNetCore.Identity;

namespace UsuariosConRoles.Models
{
    public class Usuario: IdentityUser
    {
        public ICollection<UsuarioRol> UsuariosRoles { get; set; }
    }
}
