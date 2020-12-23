using AutoMapper;
using LiteLoungeProject.StaticService.Application.Models.Query;
using LiteLoungeProject.StaticService.Application.Models.ViewModels;
using LiteLoungeProject.StaticService.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Application.Handlers.Query
{
    public class ProductsQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IProductsService _productsService;

        public ProductsQueryHandler(IMapper mapper, IProductsService productsService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productsService = productsService ?? throw new ArgumentNullException(nameof(productsService));
        }

        public async Task<GetCurrentProductsQuery.QueryResult> HandleAsync()
        {
            var currentProductDomainModels = await _productsService.GetCurrentProductsAsync(); // ????

            return new GetCurrentProductsQuery.QueryResult
            {
                CurrentProductModels = _mapper.Map<List<ProductViewModel>>(currentProductDomainModels)
            };
        }

        public async Task<GetProductQuery.QueryResult> HandleAsync(GetProductQuery query)
        {
            var productDomainModel = await _productsService.GetProductAsync(query.Id);

            return new GetProductQuery.QueryResult
            {
                ProductModel = _mapper.Map<ProductViewModel>(productDomainModel)
            };
        }
    }
}
