using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class Elder
{
    public int ElderId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? PhoneNumber { get; set; }

    public bool? Sex { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? Address { get; set; }

    public string? IdNumber { get; set; }

    public bool? IsVegetarian { get; set; }

    public string? ClothesSize { get; set; }

    public string? Username { get; set; }

    public virtual Adjust? Adjust { get; set; }

    public virtual Inbody? Inbody { get; set; }

    public virtual ICollection<JoinedRecord> JoinedRecords { get; set; } = new List<JoinedRecord>();

    public virtual ICollection<Vbtrmrecord> Vbtrmrecords { get; set; } = new List<Vbtrmrecord>();
}
