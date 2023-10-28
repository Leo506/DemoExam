﻿namespace DemoExam.Domain.Services.Orders;

public interface IOrdersService
{
    Task<IEnumerable<Domain.Models.Order>> GetAllOrders();
    Task UpdateOrder(Domain.Models.Order order);
    Task<List<Models.Order>> GetOrdersForUser(int userId);
}