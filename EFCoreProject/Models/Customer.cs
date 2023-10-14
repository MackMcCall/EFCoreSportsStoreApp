using System;
using System.Collections.Generic;

namespace EFCoreProject.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? StrFldFirstName { get; set; }

    public string? StrFldLastName { get; set; }

    public string? StrFldEmail { get; set; }

    public string? StrFldPhone { get; set; }

    public string? StrFldAddress { get; set; }

    public string? StrFldCity { get; set; }

    public string? StrFldState { get; set; }

    public string? StrFldZipcode { get; set; }

    public string? CmpLastFirst { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
