﻿
using System;

public class Payment : EntityBase
{
    public int OrderId { get; set; }
    public Order Order { get; set; }

    public DateTime PaymentDate { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; }
    public string Status { get; set; }
}
