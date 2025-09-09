using AutoMapper;
using Solution.Data.Dto;
using Solution.Domain;

namespace Solution.WebApi.Services
{
    public class MappingService
    {
        private readonly IMapper _mapper;

        public MappingService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ProductDto MapProduct(Product product)
        {
            return _mapper.Map<ProductDto>(product);
        }

        public List<ProductDto> MapProducts(List<Product> products)
        {
            return _mapper.Map<List<ProductDto>>(products);
        }

        public UserDto MapUser(User user)
        {
            return _mapper.Map<UserDto>(user);
        }

        public OrderDto MapOrder(Order order)
        {
            return _mapper.Map<OrderDto>(order);
        }

        public Product MapToProductEntity(ProductDto dto)
        {
            return _mapper.Map<Product>(dto);
        }
    }
}
