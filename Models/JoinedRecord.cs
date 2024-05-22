using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class JoinedRecord
{
    public bool? IsPaid { get; set; }

    public int? ActivityStatus { get; set; }

    public int? Review { get; set; }

    public int ActivityId { get; set; }

    public int ElderId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Elder Elder { get; set; } = null!;
}
