using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ShopEase.Application.Features.Products.Commands.CreateProduct;
using ShopEase.Application.Features.Products.Queries.GetProductList;
using ShopEase.Domain.Entities;

namespace ShopEase.Application.Features.Products.Commands.UpdateProduct
{

    public record UpdatedProductCommand(int id , UpdateProductDTO updatedProduct) : IRequest<UpdateProductDTO>;

    }