// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace fitnessApi.Models
{
    public partial class fitnessgarageContext : DbContext
    {
        public fitnessgarageContext()
        {
        }

        public fitnessgarageContext(DbContextOptions<fitnessgarageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<bundle> bundles { get; set; }
        public virtual DbSet<commentLike> commentLikes { get; set; }
        public virtual DbSet<inbody> inbodies { get; set; }
        public virtual DbSet<post> posts { get; set; }
        public virtual DbSet<postsComment> postsComments { get; set; }
        public virtual DbSet<postsLike> postsLikes { get; set; }
        public virtual DbSet<postsShare> postsShares { get; set; }
        public virtual DbSet<program> programs { get; set; }
        public virtual DbSet<programWorkout> programWorkouts { get; set; }
        public virtual DbSet<traineeBundle> traineeBundles { get; set; }
        public virtual DbSet<traineeprogram> traineeprograms { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<workout> workouts { get; set; }
        public virtual DbSet<workoutMedium> workoutMedia { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=fitnessgarage;Integrated Security=True");
        //            }
        //    "Data Source=DESKTOP-F91ETED\\MSSQLSERVER01;Initial Catalog=\"fitness garage\";Integrated Security=True"

        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.paymentDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.coach)
                    .WithMany(p => p.Paymentcoaches)
                    .HasForeignKey(d => d.coachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Payments__coachI__3E52440B");

                entity.HasOne(d => d.trainee)
                    .WithMany(p => p.Paymenttrainees)
                    .HasForeignKey(d => d.traineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Payments__traine__3F466844");
            });

            modelBuilder.Entity<bundle>(entity =>
            {
                entity.HasOne(d => d.coach)
                    .WithMany(p => p.bundles)
                    .HasForeignKey(d => d.coachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__bundle__coachId__45F365D3");
            });

            modelBuilder.Entity<commentLike>(entity =>
            {
                entity.HasOne(d => d.comment)
                    .WithMany(p => p.commentLikes)
                    .HasForeignKey(d => d.commentId)
                    .HasConstraintName("FK__commentLi__comme__3A81B327");

                entity.HasOne(d => d.user)
                    .WithMany(p => p.commentLikes)
                    .HasForeignKey(d => d.userId)
                    .HasConstraintName("FK__commentLi__userI__398D8EEE");
            });

            modelBuilder.Entity<inbody>(entity =>
            {
                entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.trainee)
                    .WithMany(p => p.inbodies)
                    .HasForeignKey(d => d.traineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__inbody__traineeI__4316F928");
            });

            modelBuilder.Entity<post>(entity =>
            {
                entity.Property(e => e.postDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.user)
                    .WithMany(p => p.posts)
                    .HasForeignKey(d => d.userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__post__userid__2B3F6F97");
            });

            modelBuilder.Entity<postsComment>(entity =>
            {
                entity.HasKey(e => e.commentId)
                    .HasName("PK__postsCom__CDDE919D511C9B2B");

                entity.HasOne(d => d.post)
                    .WithMany(p => p.postsComments)
                    .HasForeignKey(d => d.postId)
                    .HasConstraintName("FK__postsComm__postI__35BCFE0A");

                entity.HasOne(d => d.user)
                    .WithMany(p => p.postsComments)
                    .HasForeignKey(d => d.userId)
                    .HasConstraintName("FK__postsComm__userI__36B12243");
            });

            modelBuilder.Entity<postsLike>(entity =>
            {
                entity.HasKey(e => e.likeId)
                    .HasName("PK__postsLik__4FC592DB6B505F42");

                entity.HasOne(d => d.post)
                    .WithMany(p => p.postsLikes)
                    .HasForeignKey(d => d.postId)
                    .HasConstraintName("FK__postsLike__postI__2E1BDC42");

                entity.HasOne(d => d.user)
                    .WithMany(p => p.postsLikes)
                    .HasForeignKey(d => d.userId)
                    .HasConstraintName("FK__postsLike__userI__2F10007B");
            });

            modelBuilder.Entity<postsShare>(entity =>
            {
                entity.HasKey(e => e.shareId)
                    .HasName("PK__postsSha__5B2272D8414D8B2B");

                entity.HasOne(d => d.post)
                    .WithMany(p => p.postsShares)
                    .HasForeignKey(d => d.postId)
                    .HasConstraintName("FK__postsShar__postI__31EC6D26");

                entity.HasOne(d => d.user)
                    .WithMany(p => p.postsShares)
                    .HasForeignKey(d => d.userId)
                    .HasConstraintName("FK__postsShar__userI__32E0915F");
            });

            modelBuilder.Entity<program>(entity =>
            {
                entity.HasOne(d => d.coach)
                    .WithMany(p => p.programs)
                    .HasForeignKey(d => d.coachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__programs__coachI__4D94879B");
            });

            modelBuilder.Entity<programWorkout>(entity =>
            {
                entity.HasKey(e => e.progWork)
                    .HasName("PK__programW__3E8495C90EE9CA13");

                entity.HasOne(d => d.program)
                    .WithMany(p => p.programWorkouts)
                    .HasForeignKey(d => d.programId)
                    .HasConstraintName("FK__programWo__progr__571DF1D5");

                entity.HasOne(d => d.workout)
                    .WithMany(p => p.programWorkouts)
                    .HasForeignKey(d => d.workoutId)
                    .HasConstraintName("FK__programWo__worko__5629CD9C");
            });

            modelBuilder.Entity<traineeBundle>(entity =>
            {
                entity.HasKey(e => new { e.traineeId, e.bundleId })
                    .HasName("PK__traineeB__2DD306E0B9770552");

                entity.Property(e => e.subscriptionDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.bundle)
                    .WithMany(p => p.traineeBundles)
                    .HasForeignKey(d => d.bundleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__traineeBu__bundl__4AB81AF0");

                entity.HasOne(d => d.trainee)
                    .WithMany(p => p.traineeBundles)
                    .HasForeignKey(d => d.traineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__traineeBu__train__49C3F6B7");
            });

            modelBuilder.Entity<traineeprogram>(entity =>
            {
                entity.HasKey(e => e.traiProgID)
                    .HasName("PK__traineep__C7F50D15D0C318FE");

                entity.HasOne(d => d.program)
                    .WithMany(p => p.traineeprograms)
                    .HasForeignKey(d => d.programId)
                    .HasConstraintName("FK__traineepr__progr__5165187F");

                entity.HasOne(d => d.trainee)
                    .WithMany(p => p.traineeprograms)
                    .HasForeignKey(d => d.traineeId)
                    .HasConstraintName("FK__traineepr__train__5070F446");
            });

            modelBuilder.Entity<user>(entity =>
            {
                entity.Property(e => e.age).HasComputedColumnSql("(datepart(year,getdate())-datepart(year,[birthDate]))", false);

                entity.Property(e => e.registerDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<workoutMedium>(entity =>
            {
                entity.HasKey(e => e.workoutId)
                    .HasName("PK__workoutM__0986D87A3F38E280");

                entity.Property(e => e.workoutId).ValueGeneratedNever();

                entity.HasOne(d => d.workout)
                    .WithOne(p => p.workoutMedium)
                    .HasForeignKey<workoutMedium>(d => d.workoutId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__workoutMe__worko__59FA5E80");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}