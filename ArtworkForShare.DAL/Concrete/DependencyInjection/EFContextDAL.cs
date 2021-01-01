using ArtworkForShare.DAL.Abstract;
using ArtworkForShare.DAL.Concrete.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.DAL.Concrete.DependencyInjection
{
    public static class EFContextDAL
    {
        public static void AddScopedDAL(this IServiceCollection services)
        {
            services.AddScoped<IArtworkDAL, ArtworkRepository>() ;
            services.AddScoped<IClaimDAL, ClaimRepository>();            
            services.AddScoped<IUserDAL, UserRepository>();
        }
    }
}
