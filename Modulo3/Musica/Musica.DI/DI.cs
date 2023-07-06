using Microsoft.Extensions.DependencyInjection;
using Musica.Domain.Interfaces.Repositories;
using Musica.Domain.Interfaces.Services;
using Musica.Domain.Services;
using Musica.Infra.DataBase;
using Musica.Infra.DataBase.Repositories;

namespace Musica.DI
{
    public static class DI
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddDbContext<BandaDbContext>();

            services.AddScoped<IBandaServico, BandaServico>();
            services.AddScoped<IBandaRepository, BandaRepository>();

            return services;
        }
    }
}