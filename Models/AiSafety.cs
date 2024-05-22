using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class AiSafety
{
    public int SafetyId { get; set; }

    public string? SafetyArticle { get; set; }

    public string? SafetyTitle { get; set; }

    public string? Difficulty { get; set; }

    public DateTime? Time { get; set; }

    public virtual AiTopic? AiTopic { get; set; }
}
