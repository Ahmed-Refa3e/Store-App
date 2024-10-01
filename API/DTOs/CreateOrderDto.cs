using System.ComponentModel.DataAnnotations;
using Core.Entities.OrderAggregate;

namespace API.DTOs;

public class CreateOrderDto
{
    [Required(ErrorMessage = "CartId cannot be null")]
    public string CartId { get; set; } = string.Empty;

    [Required(ErrorMessage = "DeliveryMethodId cannot be null")]
    public int DeliveryMethodId { get; set; }

    [Required(ErrorMessage = "ShippingAddress cannot be null")]
    public ShippingAddress ShippingAddress { get; set; } = null!;

    [Required(ErrorMessage = "PaymentSummary cannot be null")]
    public PaymentSummary PaymentSummary { get; set; } = null!;
}
