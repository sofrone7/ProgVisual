using Microsoft.Owin;
using Owin;
using Práctica8.Models;

[assembly: OwinStartupAttribute(typeof(Práctica8.Startup))]
namespace Práctica8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // Crear el rol "Administradores" si no existe.
            ApplicationRole rolAdmin = null;
            if (!ApplicationRole.FindRole("Administradores"))
                rolAdmin = ApplicationRole.CreateRole("Administradores");
            // Crear un usuario y añadirle al rol "Administradores".
            var user = ApplicationUser.CreateUser("admin@uah.es", "admin.p8");
            if (user != null)
            {
                // Escriba aquí la línea de código que añada
                // el usuario "user" al rol "rolAdmin".
                user.AddUserToRole(rolAdmin);
                
            }
        }
    }
}
