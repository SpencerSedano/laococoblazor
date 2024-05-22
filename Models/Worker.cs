using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class Worker
{
    public int WorkerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? PhoneNumber { get; set; }

    public bool? Sex { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? Address { get; set; }

    public string? IdNumber { get; set; }

    public bool? IsVegetarian { get; set; }

    public string? ClothesSize { get; set; }

    public DateOnly? JoinedDate { get; set; }

    public string? Email { get; set; }

    public double? Salary { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();
}
