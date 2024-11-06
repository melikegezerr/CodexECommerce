

public class Shipper : EntityBase
{
    public string CompanyName { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }

    public ICollection<Order> Orders { get; set; }
}
