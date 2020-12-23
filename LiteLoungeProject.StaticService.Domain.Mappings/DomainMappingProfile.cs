using AutoMapper;
using LiteLoungeProject.StaticService.Domain.Models;
using LiteLoungeProject.StaticService.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiteLoungeProject.StaticService.Domain.Mappings
{
    public class DomainMappingProfile : Profile
    {
        public DomainMappingProfile()
        {
            CreateMap<EventEntity, EventModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));

            CreateMap<PromotionEntity, PromotionModel>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
               .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
               .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));

            CreateMap<ProductEntity, ProductModel>()
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
              .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
              .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
              .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
              .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
              .ForMember(dest => dest.CategoryModelId, opt => opt.MapFrom(src => src.CategoryModelId))
              .ForMember(dest => dest.CategoryModel, opt => opt.MapFrom(src => src.CategoryModel));

            CreateMap<CategoryEntity, CategoryModel>()
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
             .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
             .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
             .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.ProductModels, opt => opt.MapFrom(src => src.ProductModels));
        }
    }
}
