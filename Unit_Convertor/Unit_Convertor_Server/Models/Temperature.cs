using System;
using System.Collections.Generic;

namespace Unit_Convertor_Server.Models;

public partial class Temperature
{
    public Guid Id { get; set; }

    public string Ufrom { get; set; } = null!;

    public string Uto { get; set; } = null!;

    public double? Factor { get; set; }
}
