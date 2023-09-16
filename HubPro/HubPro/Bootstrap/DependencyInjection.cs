using HubPro.Hub.Application.Interfaces;
using HubPro.Hub.Application.Service;
using HubPro.Hub.Infrastructure;
using HubPro.Hub.Infrastructure.Interfaces;
using HubPro.Hub.Infrastructure.Repository;

namespace HubPro.Bootstrap
{
    public static class DependencyInjection
    {
        public static void AdicionarDependencias(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ContextHub>();

        }
    }
}
