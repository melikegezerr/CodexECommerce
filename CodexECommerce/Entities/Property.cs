
using System;
using System.Collections.Generic;

public class Property : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<ProductProperty> ProductProperties { get; set; }
}
