using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ShopEase.Application.Contracts.Persistence;
using ShopEase.Domain.Entities;

namespace ShopEase.Application.Features.Products.Queries.GetProductList
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery,List<ProductDTO>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetProductListQueryHandler(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDTO>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {

            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<List<ProductDTO>>(products);
        }
    }
}
