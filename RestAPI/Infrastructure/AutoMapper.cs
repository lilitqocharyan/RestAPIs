using AutoMapper;
using Core.Domains;
using RestAPI.RequestModels;

namespace RestAPI.Infrastructure
{
    public class AutoMapper: Profile
    {
        public AutoMapper()
        {
            CreateMap<CategoryAddRequestModel, Category>().ReverseMap();
            CreateMap<CategoryEditRequestModel, Category>().ReverseMap();
            CreateMap<ProductAddRequestModel, Product>().ReverseMap();
            CreateMap<ProductEditRequestModel, Product>().ReverseMap();
        }
    }
}
