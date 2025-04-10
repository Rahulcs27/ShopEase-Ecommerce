using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ShopEase.Domain.Entities;

namespace ShopEase.Application.Features.Products.Queries.GetProductList
{
    public class GetProductListQuery : IRequest<List<ProductDTO>> { }
}
