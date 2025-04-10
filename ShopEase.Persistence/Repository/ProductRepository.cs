using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopEase.Application.Contracts.Persistence;
using ShopEase.Domain.Entities;
using ShopEase.Persistence.Context;

namespace ShopEase.Persistence.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopEasePersistenceDbContext _context;
        private readonly ILogger<ProductRepository> _logger;


        public ProductRepository(ShopEasePersistenceDbContext context,ILogger<ProductRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            _logger.LogInformation("Fetching all products from database.");
            var products = await _context.Products.Include(p => p.Category).ToListAsync();
            _logger.LogInformation("Retrieved {Count} products.", products.Count);
            return products;

        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

        }

        public async Task<Product> AddAsync(Product product)
        {
            _logger.LogInformation("Adding new product: {Name}", product.Name);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Product added with ID: {Id}", product.Id);
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _logger.LogInformation("Updating product with ID: {Id}", product.Id);
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Product updated.");
            return product;
        }

        public async Task DeleteAsync(Product product)
        {
            _logger.LogInformation("Deleting product with ID: {Id}", product.Id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Product deleted.");

        }
    }

}
