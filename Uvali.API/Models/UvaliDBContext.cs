using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Uvali.API.Models;

public partial class UvaliDBContext : DbContext
{
    public UvaliDBContext()
    {
    }

    public UvaliDBContext(DbContextOptions<UvaliDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Answer> Answers { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Questionanswer> Questionanswers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Userqa> Userqas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:Default");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("answer_pk");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gender_pk");
        });

        modelBuilder.Entity<Participant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("participant_pk");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.Participants).HasConstraintName("participant_gender_id_fk");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("question_pk");
        });

        modelBuilder.Entity<Questionanswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("questionanswer_pk");

            entity.HasOne(d => d.AnswerNavigation).WithMany(p => p.Questionanswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("questionanswer_answer_id_fk");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.Questionanswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("questionanswer_question_id_fk");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("role_pk");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_pk");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_role_id_fk");
        });

        modelBuilder.Entity<Userqa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("userqa_pk");

            entity.HasOne(d => d.AnswerNavigation).WithMany(p => p.Userqas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("userqa_answer_id_fk");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.Userqas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("userqa_question_id_fk");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Userqas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("userqa_user_id_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
