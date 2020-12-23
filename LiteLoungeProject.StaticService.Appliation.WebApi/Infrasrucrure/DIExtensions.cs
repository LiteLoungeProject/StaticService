using AutoMapper;
using LiteLoungeProject.StaticService.Application.Handlers.Query;
using LiteLoungeProject.StaticService.Application.Mappings;
using LiteLoungeProject.StaticService.Domain.Contracts;
using LiteLoungeProject.StaticService.Domain.Contracts.Options;
using LiteLoungeProject.StaticService.Domain.Mappings;
using LiteLoungeProject.StaticService.Domain.Services;
using LiteLoungeProject.StaticService.Persistence.Contracts;
using LiteLoungeProject.StaticService.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LiteLoungeProject.StaticService.Appliation.WebApi.Infrasrucrure
{
    public static class DIExtensions
    {
        public static IServiceCollection AddAutoMapperWithProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ApplicationMappingProfile), typeof(DomainMappingProfile));
            return services;
        }

        public static IServiceCollection AddGlobalOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MemoryCacheOptions>(configuration.GetSection(nameof(MemoryCacheOptions)));
            return services;
        }

        public static IServiceCollection AddHandlers(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<EventsQueryHandler>();
            services.AddSingleton<PromotionsQueryHandler>();
            services.AddSingleton<ProductsQueryHandler>();
            services.AddSingleton<CategoriesQueryHandler>();
            return services;
        }

        public static IServiceCollection AddDomain(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IEventsService, EventsService>();
            services.AddSingleton<IPromotionsService, PromotionsService>();
            services.AddSingleton<IProductsService, ProductsService>();
            services.AddSingleton<ICategoriesService, CategoriesService>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IEventsRepository>(new EventsRepository(""));
            services.AddSingleton<IPromotionsRepository>(new PromotionsRepository(""));
            services.AddSingleton<IProductsRepository>(new ProductsRepository(""));
            services.AddSingleton<ICategoriesRepository>(new CategoriesRepository(""));

            return services;
        }
    }
}
