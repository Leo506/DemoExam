﻿using DemoExam.Core.NotifyObjects;
using DemoExam.Core.ViewModels;

namespace DemoExam.Core.Services.ViewModelServices;

public interface IProductsViewModelService
{
    IEnumerable<ProductNotifyObject> SelectProducts(string? search = null, SortOrder sortOrder = SortOrder.None,
        Func<double, bool>? discountSelectorPredicate = null);

    IEnumerable<ProductNotifyObject> GetAllProducts();

    int GetProductsCount();
    void DeleteProduct(ProductNotifyObject product);
}