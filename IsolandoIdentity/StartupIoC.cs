using Mau.PauloMau.Domain.Interfaces.Repositories;
using Mau.PauloMau.Infra.CrossCutting.Security.Configurations;
using Mau.PauloMau.Infra.CrossCutting.Security.Contexts;
using Mau.PauloMau.Infra.CrossCutting.Security.Models;
using Mau.PauloMau.Infra.Data.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;

namespace Mau.PauloMau.Infra.CrossCutting.IoC
{
    public class StartupIoC
    {
        public static void RegisterIoC(Container container)
        {
            // Identity
            container.Register<ApplicationDbContext>(Lifestyle.Scoped);
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()), Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);

            // Infra.Data.Repositories
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
        }
    }
}
