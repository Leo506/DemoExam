﻿using DemoExam.Core.Repositories;
using DemoExam.Core.Services.Order;
using Microsoft.IdentityModel.Tokens;

namespace DemoExam.Core.Services.Products;

public class ProductsService : IProductsService
{
    private readonly IProductRepository _repository;
    private readonly IOrderService _orderService;

    public ProductsService(IProductRepository repository, IOrderService orderService)
    {
        _repository = repository;
        _orderService = orderService;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        var products = await _repository.GetAllAsync();
        return products.IsNullOrEmpty()
            ? Enumerable.Empty<Product>()
            : products;
    }

    public Task<int> Count() => _repository.Count();

    public Task DeleteProduct(Product product) => _repository.DeleteAsync(product);

    public Task AddProduct(Product product)
    {
        product.Validate();
        return _repository.AddAsync(product);
    }

    public Task UpdateProduct(Product product) => _repository.UpdateAsync(product);
    public Task AddProductToOrder(Product product)
    {
        _orderService.AddProductToOrder(product.ProductArticleNumber);
        
        return Task.CompletedTask;
    }

    public bool CanOpenOrder() => _orderService.HasProductsInOrder();
}