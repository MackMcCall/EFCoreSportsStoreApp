using System;
using System.Collections.Generic;

namespace EFCoreProject.Models;

public partial class Salesperson
{
    public int SalespersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public string SalesGroupState { get; set; } = null!;

    public int SalesGroupType { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
