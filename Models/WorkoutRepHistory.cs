using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class WorkoutRepHistory
{
    public int WorkoutHistoryId { get; set; }

    public int? SetId { get; set; }

    public int? RepId { get; set; }

    public double? BackMaxWeight { get; set; }

    public double? BackAvgWeight { get; set; }

    public double? GoMaxWeight { get; set; }

    public double? GoAvgWeight { get; set; }

    public int? StartPos { get; set; }

    public int? MaxPos { get; set; }

    public int? EndPos { get; set; }

    public DateTime? StartTime { get; set; }

    public int? GoSpendTime { get; set; }

    public int? BackSpendTime { get; set; }

    public int? RestTime { get; set; }

    public int? StableScore { get; set; }

    public bool? IsEccentric { get; set; }

    public virtual WorkoutHistory WorkoutHistory { get; set; } = null!;
}
