using EntityFrameWork_Assignment.Configurations;
using EntityFrameWork_Assignment.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Assignment.Contexts
{
    public class ITIEntityDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=ITIEntity;Trusted_Connection=true;TrustServerCertificate =true");   //connection string
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new Stud_Course_Configutations());

            modelBuilder.Entity<Stud_Course>()
                        .HasKey(SC => new { SC.StudentId, SC.CourseId });

            modelBuilder.Entity<Course_Inst>()
                        .HasKey(CI => new { CI.CourseId, CI.InstructorId });


            modelBuilder.Entity<Department>()
                        .Property(d => d.CreationDate)
                        .HasDefaultValueSql("GETDATE()");

        }

        public DbSet<Student> Students { get; set; } 

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

    }
}
