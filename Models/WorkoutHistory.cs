using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class WorkoutHistory
{
    public int WorkoutHistoryId { get; set; }

    public int? WorkoutId { get; set; }

    public int? Cycle { get; set; }

    public int? WorkoutTime { get; set; }

    public int? Score { get; set; }

    public int? StableScore { get; set; }

    public bool? IsEccentntric { get; set; }

    public double? TotalWeight { get; set; }

    public double? TotalLength { get; set; }

    public DateTime? StartTime { get; set; }

    public string? Mode { get; set; }

    public virtual WorkoutRepHistory? WorkoutRepHistory { get; set; }

    public virtual WorkoutSetHistory? WorkoutSetHistory { get; set; }
}
