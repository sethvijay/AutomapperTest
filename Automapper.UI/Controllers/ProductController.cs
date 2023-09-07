using Automapper.UI.Models.Product;
using Automapper.UI.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Automapper.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository,IMapper mapper)
        {
            _ProductRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult ProductIntegration()
        {
            var usersFromRepository = _ProductRepository.GetAllProducts();
            var usersReadDto = _mapper.Map<List<ProductExistingModel>>(usersFromRepository);
            return View(usersReadDto);
        }
    }
}
