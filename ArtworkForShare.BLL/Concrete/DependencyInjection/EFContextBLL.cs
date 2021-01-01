using ArtworkForShare.BLL.Abstract;
using ArtworkForShare.DAL.Concrete.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.BLL.Concrete.DependencyInjection
{
    public static class EFContextBLL
    {
        public static void AddScopedBLL(this IServiceCollection services)
        {
            services.AddScopedDAL();
            services.AddScoped<IArtworkBLL, ArtworkService>();
            services.AddScoped<IClaimBLL, ClaimService>();            
            services.AddScoped<IUserBLL, UserService>();
        }
    }
}
