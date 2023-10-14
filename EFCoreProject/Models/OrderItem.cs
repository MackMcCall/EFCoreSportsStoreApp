﻿using System;
using System.Collections.Generic;

namespace EFCoreProject.Models;

public partial class OrderItem
{
    public int OrderItemId { get; set; }

    public int OrderId { get; set; }

    public string ProductId { get; set; } = null!;

    public int? Quantity { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
