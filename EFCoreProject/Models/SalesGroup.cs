using System;
using System.Collections.Generic;

namespace EFCoreProject.Models;

public partial class SalesGroup
{
    public int Id { get; set; }

    public string State { get; set; } = null!;

    public int Type { get; set; }
}
