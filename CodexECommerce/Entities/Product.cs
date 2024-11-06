﻿
using System;
using System.Collections.Generic;

public class Product : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<ProductProperty> ProductProperties { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}
