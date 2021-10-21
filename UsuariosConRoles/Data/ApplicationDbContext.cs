using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsuariosConRoles.Models;

namespace UsuariosConRoles.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario, Rol, string,
        IdentityUserClaim<string>, UsuarioRol, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Usuario>(b =>
            {
                b.HasMany(e => e.UsuariosRoles)
                .WithOne(e => e.Usuario)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
            });

            builder.Entity<Rol>(b =>
            {
                b.HasMany(e => e.UsuariosRoles)
                .WithOne(e => e.Rol)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();
            });

            Seed(builder);
        }

        private void Seed(ModelBuilder builder)
        {
            var usuarioAdmin = new Usuario()
            {
                Email = "usuarioAdmin@hotmail.com",
                NormalizedEmail = "USUARIOADMIN@HOTMAIL.COM",
                UserName = "usuarioAdmin",
                NormalizedUserName = "USUARIOADMIN"
            };

            var usuarioVendedor = new Usuario()
            {
                Email = "usuarioVendedor@hotmail.com",
                NormalizedEmail = "USUARIOVENDEDOR@HOTMAIL.COM",
                UserName = "usuarioVendedor",
                NormalizedUserName = "USUARIOVENDEDOR"
            };

            var usuarioSinRol = new Usuario()
            {
                Email = "usuarioSinRol@hotmail.com",
                NormalizedEmail = "USUARIOSINROL@HOTMAIL.COM",
                UserName = "usuarioSinRol",
                NormalizedUserName = "USUARIOSINROL"
            };

            var rolAdmin = new Rol()
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            };

            var rolVendedor = new Rol()
            {
                Name = "Vendedor",
                NormalizedName = "VENDEDOR"
            };

            builder.Entity<Rol>().HasData(rolAdmin, rolVendedor);
            builder.Entity<Usuario>().HasData(usuarioAdmin, usuarioVendedor, usuarioSinRol);

            var userRoleAdmin = new UsuarioRol()
            {
                RoleId = rolAdmin.Id,
                UserId = usuarioAdmin.Id
            };

            var userRoleVendedor = new UsuarioRol()
            {
                RoleId = rolVendedor.Id,
                UserId = usuarioVendedor.Id
            };

            builder.Entity<UsuarioRol>().HasData(userRoleAdmin, userRoleVendedor);
        }
    }
}