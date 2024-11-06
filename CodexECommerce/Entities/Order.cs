
using System;
using System.Collections.Generic;

public class Order : EntityBase
{
    public string UserId { get; set; }
    public User User { get; set; }

    public int ShipperId { get; set; }
    public Shipper Shipper { get; set; }

    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
    public string ShippingAddress { get; set; }
    public decimal TotalAmount { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }
    public Payment Payment { get; set; }
}
