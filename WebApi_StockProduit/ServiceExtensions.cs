using Contrat;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_StockProduit
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddSingleton<IMouvementRepository, MouvementRepository>();
            services.AddSingleton<IProduitRepository, ProduitRepository>();
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IProduitRepository, ProduitRepository>();
        }

    }
}
