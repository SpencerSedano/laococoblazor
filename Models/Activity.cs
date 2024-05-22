using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class Activity
{
    public int ActivityId { get; set; }

    public double? Price { get; set; }

    public string? ChName { get; set; }

    public string? EngName { get; set; }

    public int? ContactPhone { get; set; }

    public string? ContactEmail { get; set; }

    public DateOnly? Date { get; set; }

    public string? Place { get; set; }

    public int? PeopleLimit { get; set; }

    public int? WorkerId { get; set; }

    public virtual ICollection<JoinedRecord> JoinedRecords { get; set; } = new List<JoinedRecord>();

    public virtual Worker? Worker { get; set; }
}
