using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ShopEase.Application.Contracts.Persistence;
using ShopEase.Domain.Entities;

namespace ShopEase.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        readonly IProductRepository _productRepository;
        readonly IMapper _mapper;
        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var prod = _mapper.Map<Product>(request.newProduct); 
            var newProduct = await _productRepository.AddAsync(prod);
            return newProduct;
        }
    }
}
