using System;
using Mau.PauloMau.Infra.CrossCutting.Security.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mau.PauloMau.Infra.CrossCutting.Security.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}