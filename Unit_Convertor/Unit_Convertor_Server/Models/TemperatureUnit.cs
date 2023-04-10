using System;
using System.Collections.Generic;

namespace Unit_Convertor_Server.Models;

public partial class TemperatureUnit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Unit { get; set; } = null!;
}
