using AutoMapper;
using LiteLoungeProject.StaticService.Domain.Contracts;
using LiteLoungeProject.StaticService.Domain.Models;
using LiteLoungeProject.StaticService.Persistence.Contracts;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Domain.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _cache;
        private readonly Contracts.Options.MemoryCacheOptions _cacheOptions;

        public ProductsService(IProductsRepository productsRepository, IMapper mapper, IMemoryCache cache, IOptions<Contracts.Options.MemoryCacheOptions> cacheOptions)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _cacheOptions = cacheOptions?.Value ?? throw new ArgumentNullException(nameof(cacheOptions));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productsRepository = productsRepository ?? throw new ArgumentNullException(nameof(productsRepository));
        }

        public async Task<List<ProductModel>> GetCurrentProductsAsync()
        {
            var key = $"currentProducts";
            var productEntities = await GetOrCreateAsync(key, pr => _productsRepository.GetCurrentProductsAsync());
            return _mapper.Map<List<ProductModel>>(productEntities);
        }

        public async Task<ProductModel> GetProductAsync(int id)
        {
            var key = $"currentProduct-{id}";
            var productEntity = await GetOrCreateAsync(key, pr => _productsRepository.GetProductAsync(id));
            return _mapper.Map<ProductModel>(productEntity);
        }

        private async Task<T> GetOrCreateAsync<T>(string key, Func<IProductsRepository, Task<T>> create)
        {
            return await _cache.GetOrCreateAsync(key, async entry =>
            {
                entry.SetAbsoluteExpiration(_cacheOptions.RepositoryMamoryCacheTimeout);
                return await create(_productsRepository);
            });
        }
    }
}
