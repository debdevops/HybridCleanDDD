using HybridCleanDDD.Domain.Entities;
using HybridCleanDDD.Domain.Interfaces;

namespace HybridCleanDDD.Application.Services;

public class OrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<Guid> CreateOrderAsync(string productName, int quantity, decimal price)
{
    // Creating the order with the correct constructor
    var order = new Order(productName, quantity, price);

    // Add order to the repository
    await _orderRepository.AddAsync(order);

    // Return the Order ID (which is a GUID)
    return order.Id;
}


    public async Task<Order?> GetOrderByIdAsync(Guid id)
    {
        return await _orderRepository.GetByIdAsync(id);
    }

    public async Task UpdateOrderQuantityAsync(Guid id, int quantity)
    {
        var order = await _orderRepository.GetByIdAsync(id);
        if (order == null)
        {
            throw new KeyNotFoundException("Order not found.");
        }

        order.UpdateQuantity(quantity);
        await _orderRepository.UpdateAsync(order);
    }

    public async Task DeleteOrderAsync(Guid id)
    {
        await _orderRepository.DeleteAsync(id);
    }
}
