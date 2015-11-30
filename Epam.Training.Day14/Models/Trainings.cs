namespace Epam.Training.Day14.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Trainings : DbContext
    {
        public Trainings()
            : base("name=TrainingsContext")
        {
        }

        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<University> Universities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cours>()
                .HasMany(e => e.Records)
                .WithRequired(e => e.Cours)
                .HasForeignKey(e => e.CourseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Records)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
