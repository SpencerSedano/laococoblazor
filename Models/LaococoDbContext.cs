using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace laococoblazor.Models;

public partial class LaococoDbContext : DbContext
{
    public LaococoDbContext()
    {
    }

    public LaococoDbContext(DbContextOptions<LaococoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<Adjust> Adjusts { get; set; }

    public virtual DbSet<AiSafety> AiSafeties { get; set; }

    public virtual DbSet<AiTopic> AiTopics { get; set; }

    public virtual DbSet<Elder> Elders { get; set; }

    public virtual DbSet<Exercise> Exercises { get; set; }

    public virtual DbSet<Fraction> Fractions { get; set; }

    public virtual DbSet<Inbody> Inbodies { get; set; }

    public virtual DbSet<JoinedRecord> JoinedRecords { get; set; }

    public virtual DbSet<Vbtrmrecord> Vbtrmrecords { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    public virtual DbSet<WorkoutHistory> WorkoutHistories { get; set; }

    public virtual DbSet<WorkoutRepHistory> WorkoutRepHistories { get; set; }

    public virtual DbSet<WorkoutSetHistory> WorkoutSetHistories { get; set; }

    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SPENCER\\SQLEXPRESS;Database=elderly;User=spencersedano;Password=1234;TrustServerCertificate=True");*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>(entity =>
        {
            entity.ToTable("Activity");

            entity.HasIndex(e => e.WorkerId, "IX_Relationship4");

            entity.Property(e => e.ActivityId)
                .ValueGeneratedNever()
                .HasColumnName("activity_id");
            entity.Property(e => e.ChName)
                .IsUnicode(false)
                .HasColumnName("ch_name");
            entity.Property(e => e.ContactEmail)
                .IsUnicode(false)
                .HasColumnName("contact_email");
            entity.Property(e => e.ContactPhone).HasColumnName("contact_phone");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EngName)
                .IsUnicode(false)
                .HasColumnName("eng_name");
            entity.Property(e => e.PeopleLimit).HasColumnName("people_limit");
            entity.Property(e => e.Place)
                .IsUnicode(false)
                .HasColumnName("place");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.WorkerId).HasColumnName("worker_id");

            entity.HasOne(d => d.Worker).WithMany(p => p.Activities)
                .HasForeignKey(d => d.WorkerId)
                .HasConstraintName("responsability");
        });

        modelBuilder.Entity<Adjust>(entity =>
        {
            entity.HasKey(e => e.ElderId);

            entity.ToTable("adjust");

            entity.Property(e => e.ElderId)
                .ValueGeneratedNever()
                .HasColumnName("elder_id");
            entity.Property(e => e.ActionsCantBeDone).HasColumnName("actions_cant_be_done");
            entity.Property(e => e.AdjustBack)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("adjust_back");
            entity.Property(e => e.AdjustChair)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("adjust_chair");
            entity.Property(e => e.AdjustHand)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("adjust_hand");
            entity.Property(e => e.AdjustTpush)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("adjust_tpush");
            entity.Property(e => e.ExerciseId).HasColumnName("exercise_id");

            entity.HasOne(d => d.Elder).WithOne(p => p.Adjust)
                .HasForeignKey<Adjust>(d => d.ElderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_adjust_Elder1");

            entity.HasOne(d => d.Exercise).WithMany(p => p.Adjusts)
                .HasForeignKey(d => d.ExerciseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_adjust_Exercise1");
        });

        modelBuilder.Entity<AiSafety>(entity =>
        {
            entity.HasKey(e => e.SafetyId);

            entity.ToTable("aiSafety");

            entity.Property(e => e.SafetyId)
                .ValueGeneratedNever()
                .HasColumnName("safety_id");
            entity.Property(e => e.Difficulty)
                .HasMaxLength(20)
                .HasColumnName("difficulty");
            entity.Property(e => e.SafetyArticle).HasColumnName("safety_article");
            entity.Property(e => e.SafetyTitle)
                .HasMaxLength(50)
                .HasColumnName("safety_title");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
        });

        modelBuilder.Entity<AiTopic>(entity =>
        {
            entity.HasKey(e => e.SafetyId);

            entity.ToTable("aiTopic");

            entity.Property(e => e.SafetyId)
                .ValueGeneratedNever()
                .HasColumnName("safety_id");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Options1)
                .HasMaxLength(50)
                .HasColumnName("options_1");
            entity.Property(e => e.Topic)
                .HasMaxLength(50)
                .HasColumnName("topic");
            entity.Property(e => e.TopicId).HasColumnName("topic_id");

            entity.HasOne(d => d.Safety).WithOne(p => p.AiTopic)
                .HasForeignKey<AiTopic>(d => d.SafetyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_aiTopic_aiSafety1");
        });

        modelBuilder.Entity<Elder>(entity =>
        {
            entity.ToTable("Elder");

            entity.Property(e => e.ElderId)
                .ValueGeneratedNever()
                .HasColumnName("elder_id");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.ClothesSize)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("clothes_size");
            entity.Property(e => e.FirstName)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id_number");
            entity.Property(e => e.IsVegetarian).HasColumnName("is_vegetarian");
            entity.Property(e => e.LastName)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.Sex).HasColumnName("sex");
            entity.Property(e => e.Username)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Exercise>(entity =>
        {
            entity.HasKey(e => e.ExerciseId).HasName("PK__Exercise__C121418E4310ED32");

            entity.ToTable("Exercise");

            entity.Property(e => e.ExerciseId)
                .ValueGeneratedNever()
                .HasColumnName("exercise_id");
            entity.Property(e => e.BodyEffect).HasColumnName("body_effect");
            entity.Property(e => e.ExerciseDescription).HasColumnName("exercise_description");
            entity.Property(e => e.ExerciseName).HasColumnName("exercise_name");
            entity.Property(e => e.FitnessEffect).HasColumnName("fitness_effect");
            entity.Property(e => e.Lifestyle).HasColumnName("lifestyle");
            entity.Property(e => e.Muscles).HasColumnName("muscles");
            entity.Property(e => e.SoundPrompt).HasColumnName("sound_prompt");
        });

        modelBuilder.Entity<Fraction>(entity =>
        {
            entity.HasKey(e => e.ElderId);

            entity.ToTable("Fraction");

            entity.Property(e => e.ElderId)
                .ValueGeneratedNever()
                .HasColumnName("elder_id");
            entity.Property(e => e.Fraction1).HasColumnName("fraction");
            entity.Property(e => e.SafetyId).HasColumnName("safety_id");
        });

        modelBuilder.Entity<Inbody>(entity =>
        {
            entity.HasKey(e => e.ElderId);

            entity.ToTable("inbody");

            entity.Property(e => e.ElderId)
                .ValueGeneratedNever()
                .HasColumnName("elder_id");
            entity.Property(e => e.BasalMetabolism).HasColumnName("basal_metabolism");
            entity.Property(e => e.Bmi).HasColumnName("bmi");
            entity.Property(e => e.BodyFatPercentage).HasColumnName("body_fat_percentage");
            entity.Property(e => e.BodyWater).HasColumnName("body_water");
            entity.Property(e => e.BoneMass).HasColumnName("bone_mass");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.InternalAge).HasColumnName("internal_age");
            entity.Property(e => e.MuscleMass).HasColumnName("muscle_mass");
            entity.Property(e => e.PhysiologicalLevel).HasColumnName("physiological_level");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.Elder).WithOne(p => p.Inbody)
                .HasForeignKey<Inbody>(d => d.ElderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_inbody_Elder1");
        });

        modelBuilder.Entity<JoinedRecord>(entity =>
        {
            entity.HasKey(e => new { e.ActivityId, e.ElderId });

            entity.ToTable("joined_record");

            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.ElderId).HasColumnName("elder_id");
            entity.Property(e => e.ActivityStatus).HasColumnName("activity_status");
            entity.Property(e => e.IsPaid).HasColumnName("is_paid");
            entity.Property(e => e.Review).HasColumnName("review");

            entity.HasOne(d => d.Activity).WithMany(p => p.JoinedRecords)
                .HasForeignKey(d => d.ActivityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("activity_information");

            entity.HasOne(d => d.Elder).WithMany(p => p.JoinedRecords)
                .HasForeignKey(d => d.ElderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("joined_activity");
        });

        modelBuilder.Entity<Vbtrmrecord>(entity =>
        {
            entity.HasKey(e => e.RmrecordId).HasName("PK__VBTRMREC__2FE38456D892E35D");

            entity.ToTable("VBTRMRECORD");

            entity.Property(e => e.RmrecordId)
                .ValueGeneratedNever()
                .HasColumnName("rmrecord_id");
            entity.Property(e => e.ElderId).HasColumnName("elder_id");
            entity.Property(e => e.ExerciseId).HasColumnName("exercise_id");
            entity.Property(e => e.RecordTime)
                .HasColumnType("datetime")
                .HasColumnName("record_time");
            entity.Property(e => e.UserMaxPosition).HasColumnName("user_max_position");
            entity.Property(e => e.UserMaxWeight).HasColumnName("user_max_weight");
            entity.Property(e => e.UserStartPosition).HasColumnName("user_start_position");
            entity.Property(e => e.WeightJson)
                .IsUnicode(false)
                .HasColumnName("weight_json");

            entity.HasOne(d => d.Elder).WithMany(p => p.Vbtrmrecords)
                .HasForeignKey(d => d.ElderId)
                .HasConstraintName("FK_elder_id");

            entity.HasOne(d => d.Exercise).WithMany(p => p.Vbtrmrecords)
                .HasForeignKey(d => d.ExerciseId)
                .HasConstraintName("FK_exercise_id");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.ToTable("Worker");

            entity.Property(e => e.WorkerId)
                .ValueGeneratedNever()
                .HasColumnName("worker_id");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.ClothesSize)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("clothes_size");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id_number");
            entity.Property(e => e.IsVegetarian).HasColumnName("is_vegetarian");
            entity.Property(e => e.JoinedDate).HasColumnName("joined_date");
            entity.Property(e => e.LastName)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.Salary).HasColumnName("salary");
            entity.Property(e => e.Sex).HasColumnName("sex");
        });

        modelBuilder.Entity<WorkoutHistory>(entity =>
        {
            entity.HasKey(e => e.WorkoutHistoryId).HasName("PK__workout___D158CA7A9B273525");

            entity.ToTable("workout_history");

            entity.Property(e => e.WorkoutHistoryId)
                .ValueGeneratedNever()
                .HasColumnName("workout_history_id");
            entity.Property(e => e.Cycle).HasColumnName("cycle");
            entity.Property(e => e.IsEccentntric).HasColumnName("is_eccentntric");
            entity.Property(e => e.Mode).HasColumnName("mode");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.StableScore).HasColumnName("stable_score");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");
            entity.Property(e => e.TotalLength).HasColumnName("total_length");
            entity.Property(e => e.TotalWeight).HasColumnName("total_weight");
            entity.Property(e => e.WorkoutId).HasColumnName("workout_id");
            entity.Property(e => e.WorkoutTime).HasColumnName("workout_time");
        });

        modelBuilder.Entity<WorkoutRepHistory>(entity =>
        {
            entity.HasKey(e => e.WorkoutHistoryId);

            entity.ToTable("workout_rep_history");

            entity.Property(e => e.WorkoutHistoryId)
                .ValueGeneratedNever()
                .HasColumnName("workout_history_id");
            entity.Property(e => e.BackAvgWeight).HasColumnName("back_avg_weight");
            entity.Property(e => e.BackMaxWeight).HasColumnName("back_max_weight");
            entity.Property(e => e.BackSpendTime).HasColumnName("back_spend_time");
            entity.Property(e => e.EndPos).HasColumnName("end_pos");
            entity.Property(e => e.GoAvgWeight).HasColumnName("go_avg_weight");
            entity.Property(e => e.GoMaxWeight).HasColumnName("go_max_weight");
            entity.Property(e => e.GoSpendTime).HasColumnName("go_spend_time");
            entity.Property(e => e.IsEccentric).HasColumnName("is_eccentric");
            entity.Property(e => e.MaxPos).HasColumnName("max_pos");
            entity.Property(e => e.RepId).HasColumnName("rep_id");
            entity.Property(e => e.RestTime).HasColumnName("rest_time");
            entity.Property(e => e.SetId).HasColumnName("set_id");
            entity.Property(e => e.StableScore).HasColumnName("stable_score");
            entity.Property(e => e.StartPos).HasColumnName("start_pos");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");

            entity.HasOne(d => d.WorkoutHistory).WithOne(p => p.WorkoutRepHistory)
                .HasForeignKey<WorkoutRepHistory>(d => d.WorkoutHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_workout_rep_history_workout_history");
        });

        modelBuilder.Entity<WorkoutSetHistory>(entity =>
        {
            entity.HasKey(e => e.WorkoutHistoryId);

            entity.ToTable("workout_set_history");

            entity.Property(e => e.WorkoutHistoryId)
                .ValueGeneratedNever()
                .HasColumnName("workout_history_id");
            entity.Property(e => e.FinishedReps).HasColumnName("finished_reps");
            entity.Property(e => e.SetId).HasColumnName("set_id");
            entity.Property(e => e.StableScore).HasColumnName("stable_score");
            entity.Property(e => e.TotalLength).HasColumnName("total_length");
            entity.Property(e => e.TotalReps).HasColumnName("total_reps");
            entity.Property(e => e.TotalWeight).HasColumnName("total_weight");

            entity.HasOne(d => d.WorkoutHistory).WithOne(p => p.WorkoutSetHistory)
                .HasForeignKey<WorkoutSetHistory>(d => d.WorkoutHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_workout_set_history_workout_history");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
