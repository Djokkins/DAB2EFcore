using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAB2.Data
{
    public class Helpsystem : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=helpsystem.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasKey(c => c.courseId);
            modelBuilder.Entity<Exercise>()
                .HasKey(c => c.number);
            modelBuilder.Entity<Student>()
                .HasKey(c => c.AuId);
            modelBuilder.Entity<Teacher>()
                .HasKey(c => c.AuId);
        }
    }
}
