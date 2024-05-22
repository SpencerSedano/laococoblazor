using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class Adjust
{
    public int ElderId { get; set; }

    public int ExerciseId { get; set; }

    public string? AdjustBack { get; set; }

    public string? AdjustTpush { get; set; }

    public string? AdjustChair { get; set; }

    public string? AdjustHand { get; set; }

    public string? ActionsCantBeDone { get; set; }

    public virtual Elder Elder { get; set; } = null!;

    public virtual Exercise Exercise { get; set; } = null!;
}
