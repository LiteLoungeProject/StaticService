using AutoMapper;
using LiteLoungeProject.StaticService.Application.Models.Query;
using LiteLoungeProject.StaticService.Application.Models.ViewModels;
using LiteLoungeProject.StaticService.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Application.Handlers.Query
{
    public class PromotionsQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IPromotionsService _promotionsService;

        public PromotionsQueryHandler(IMapper mapper, IPromotionsService promotionsService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _promotionsService = promotionsService ?? throw new ArgumentNullException(nameof(promotionsService));
        }

        public async Task<GetCurrentPromotionsQuery.QueryResult> HandleAsync()
        {
            var currentPromotionDomainModels = await _promotionsService.GetCurrentPromotionsAsync();

            return new GetCurrentPromotionsQuery.QueryResult
            {
                CurrentPromotionModels = _mapper.Map<List<PromotionViewModel>>(currentPromotionDomainModels)
            };
        }

        public async Task<GetPromotionQuery.QueryResult> HandleAsync(GetPromotionQuery query)
        {
            var promotionDomainModel = await _promotionsService.GetPromotionAsync(query.Id);

            return new GetPromotionQuery.QueryResult
            {
                PromotionModel = _mapper.Map<PromotionViewModel>(promotionDomainModel)
            };
        }
    }
}
