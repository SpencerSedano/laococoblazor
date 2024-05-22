using System;
using System.Collections.Generic;

namespace laococoblazor.Models;

public partial class Exercise
{
    public int ExerciseId { get; set; }

    public string ExerciseName { get; set; } = null!;

    public string? Muscles { get; set; }

    public string? FitnessEffect { get; set; }

    public string? BodyEffect { get; set; }

    public string? ExerciseDescription { get; set; }

    public string? Lifestyle { get; set; }

    public string? SoundPrompt { get; set; }

    public virtual ICollection<Adjust> Adjusts { get; set; } = new List<Adjust>();

    public virtual ICollection<Vbtrmrecord> Vbtrmrecords { get; set; } = new List<Vbtrmrecord>();
}
