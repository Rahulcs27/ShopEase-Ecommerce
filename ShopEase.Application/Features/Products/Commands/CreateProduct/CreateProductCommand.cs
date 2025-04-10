using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ShopEase.Domain.Entities;

namespace ShopEase.Application.Features.Products.Commands.CreateProduct
{
    public record CreateProductCommand(CreateProductDTO newProduct) : IRequest<Product>;

}
