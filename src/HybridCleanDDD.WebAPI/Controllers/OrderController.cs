using HybridCleanDDD.Application.Services;
using HybridCleanDDD.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HybridCleanDDD.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly OrderService _orderService;

    public OrderController(OrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(string productName, int quantity, decimal price)
    {
        var orderId = await _orderService.CreateOrderAsync(productName, quantity, price);
        return CreatedAtAction(nameof(GetOrder), new { id = orderId }, null);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrder(Guid id)
    {
        var order = await _orderService.GetOrderByIdAsync(id);
        if (order == null) return NotFound();

        return Ok(order);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateOrderQuantity(Guid id, int quantity)
    {
        try
        {
            await _orderService.UpdateOrderQuantityAsync(id, quantity);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOrder(Guid id)
    {
        await _orderService.DeleteOrderAsync(id);
        return NoContent();
    }
}
