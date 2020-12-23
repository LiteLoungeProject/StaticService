using AutoMapper;
using LiteLoungeProject.StaticService.Application.Models.Query;
using LiteLoungeProject.StaticService.Application.Models.ViewModels;
using LiteLoungeProject.StaticService.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Application.Handlers.Query
{
    public class CategoriesQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly ICategoriesService _categoriesService;

        public CategoriesQueryHandler(IMapper mapper, ICategoriesService categoriesService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _categoriesService = categoriesService ?? throw new ArgumentNullException(nameof(categoriesService));
        }

        public async Task<GetCurrentCategoriesQuery.QueryResult> HandleAsync()
        {
            var currentCategoryDomainModels = await _categoriesService.GetCurrentCategoriesAsync();

            return new GetCurrentCategoriesQuery.QueryResult
            {
                CurrentCategoryModels = _mapper.Map<List<CategoryViewModel>>(currentCategoryDomainModels)
            };
        }

        public async Task<GetCategoryQuery.QueryResult> HandleAsync(GetCategoryQuery query)
        {
            var categoryDomainModel = await _categoriesService.GetCategoryAsync(query.Id);

            return new GetCategoryQuery.QueryResult
            {
                CategoryModel = _mapper.Map<CategoryViewModel>(categoryDomainModel)
            };
        }
    }
}
