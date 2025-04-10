using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ShopEase.Application.Contracts.Persistence;
using ShopEase.Application.Features.Products.Queries.GetProductList;
using ShopEase.Domain.Entities;

namespace ShopEase.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdatedProductCommand, UpdateProductDTO>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<UpdateProductDTO> Handle(UpdatedProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.id);

            var uprod = _mapper.Map(request.updatedProduct, product);

            await _productRepository.UpdateAsync(uprod);

            return request.updatedProduct;
        }
    }
}
