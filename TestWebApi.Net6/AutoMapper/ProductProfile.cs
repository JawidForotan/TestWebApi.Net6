

namespace TestWebApi.Net6.AutoMapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            //CreateMap<ProductDTO, Product>();
        }

    }
}
