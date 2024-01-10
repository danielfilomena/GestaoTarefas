
using GT.Application.Interfaces;
using GT.Application.Services;
using GT.Data.Context;
using GT.Data.Repositories;
using GT.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GT.IoC
{
    public static class InfraEstrutura
    {

        public static IServiceCollection AddInfraEstrutura(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<TarefaContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Thunders")));

            services.AddScoped<ITarefa, TarefaRepository>();

            services.AddScoped<ITarefaService, TarefaService>();

            return services;

        }

    }
}
