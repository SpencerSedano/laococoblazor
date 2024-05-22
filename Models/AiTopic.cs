using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class AiTopic
{
    public int SafetyId { get; set; }

    public int? TopicId { get; set; }

    public string? Topic { get; set; }

    public string? Options1 { get; set; }

    public int? Answer { get; set; }

    public virtual AiSafety Safety { get; set; } = null!;
}
