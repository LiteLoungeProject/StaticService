using AutoMapper;
using LiteLoungeProject.StaticService.Domain.Contracts;
using LiteLoungeProject.StaticService.Domain.Models;
using LiteLoungeProject.StaticService.Persistence.Contracts;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Domain.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _cache;
        private readonly Contracts.Options.MemoryCacheOptions _cacheOptions;

        public CategoriesService(ICategoriesRepository categoriesRepository, IMapper mapper, IMemoryCache cache, IOptions<Contracts.Options.MemoryCacheOptions> cacheOptions)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _cacheOptions = cacheOptions?.Value ?? throw new ArgumentNullException(nameof(cacheOptions));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _categoriesRepository = categoriesRepository ?? throw new ArgumentNullException(nameof(categoriesRepository));
        }

        public async Task<List<CategoryModel>> GetCurrentCategoriesAsync()
        {
            var key = $"currentCategories";
            var categoryEntities = await GetOrCreateAsync(key, cat => _categoriesRepository.GetCurrentCategoriesAsync());
            return _mapper.Map<List<CategoryModel>>(categoryEntities);
        }

        public async Task<CategoryModel> GetCategoryAsync(int id)
        {
            var key = $"currentCategory-{id}";
            var categoryEntity = await GetOrCreateAsync(key, cat => _categoriesRepository.GetCategoryAsync(id));
            return _mapper.Map<CategoryModel>(categoryEntity);
        }

        private async Task<T> GetOrCreateAsync<T>(string key, Func<ICategoriesRepository, Task<T>> create)
        {
            return await _cache.GetOrCreateAsync(key, async entry =>
            {
                entry.SetAbsoluteExpiration(_cacheOptions.RepositoryMamoryCacheTimeout);
                return await create(_categoriesRepository);
            });
        }
    }
}
