using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class Inbody
{
    public int ElderId { get; set; }

    public double? Height { get; set; }

    public double? Weight { get; set; }

    public double? Bmi { get; set; }

    public double? BodyFatPercentage { get; set; }

    public double? BodyWater { get; set; }

    public double? MuscleMass { get; set; }

    public string? PhysiologicalLevel { get; set; }

    public double? BoneMass { get; set; }

    public string? BasalMetabolism { get; set; }

    public int? InternalAge { get; set; }

    public virtual Elder Elder { get; set; } = null!;
}
