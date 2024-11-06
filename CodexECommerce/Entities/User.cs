using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

public class User : IdentityUser
{
    public string Address { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<Order> Orders { get; set; }
}
