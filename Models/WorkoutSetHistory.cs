using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class WorkoutSetHistory
{
    public int WorkoutHistoryId { get; set; }

    public int? SetId { get; set; }

    public int? TotalReps { get; set; }

    public int? FinishedReps { get; set; }

    public double? TotalWeight { get; set; }

    public double? TotalLength { get; set; }

    public int? StableScore { get; set; }

    public virtual WorkoutHistory WorkoutHistory { get; set; } = null!;
}
