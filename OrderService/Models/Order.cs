﻿namespace OrderService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount => ProductPrice * Quantity;
    }
}
