using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class Vbtrmrecord
{
    public int RmrecordId { get; set; }

    public string? WeightJson { get; set; }

    public int? UserStartPosition { get; set; }

    public int? UserMaxPosition { get; set; }

    public double? UserMaxWeight { get; set; }

    public int? ElderId { get; set; }

    public int? ExerciseId { get; set; }

    public DateTime? RecordTime { get; set; }

    public virtual Elder? Elder { get; set; }

    public virtual Exercise? Exercise { get; set; }
}
