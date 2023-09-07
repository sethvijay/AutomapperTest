using Automapper.UI.Models.Product;
using AutoMapper;
using Domain;

namespace Automapper.UI.Infrastructure.Mapper
{
    public class MyFoodMapperConfiguration : Profile
    {
        public MyFoodMapperConfiguration()
        {
            //Create Specific Maps
            CreateProductIntegrationMaps();
        }

        /// <summary>
        /// Create Product Integration Maps
        /// </summary>
        protected virtual void CreateProductIntegrationMaps()
        {
            CreateMap<Product, ProductExistingModel>();
            CreateMap<ProductExistingUpdateModel, Product>();
        }
    }
}
