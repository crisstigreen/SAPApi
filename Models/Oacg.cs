using System;
using System.Collections.Generic;

namespace SAPApi.Models;

public partial class Oacg
{
    public int AbsId { get; set; }

    public string Name { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string? Locked { get; set; }

    public string? DateSource { get; set; }

    public string? UserSign { get; set; }
}
