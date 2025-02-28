﻿// <auto-generated />
using System;
using EntityFrameWork_Assignment.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameWork_Assignment.Migrations
{
    [DbContext(typeof(ITIEntityDBContext))]
    [Migration("20250228093354_make the date in the department from sql")]
    partial class makethedateinthedepartmentfromsql
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<int?>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("TopicId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Course_Inst", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Evaluate")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("CourseId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Course_Insts");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("InsructorId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructorId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<decimal?>("Bonus")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<decimal?>("HourRate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("InstructorId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Stud_Course", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Stud_Course");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<string>("LName")
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TopicId"));

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Course", b =>
                {
                    b.HasOne("EntityFrameWork_Assignment.Models.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("TopicId");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Course_Inst", b =>
                {
                    b.HasOne("EntityFrameWork_Assignment.Models.Course", null)
                        .WithMany("Courses_Inst")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Assignment.Models.Instructor", null)
                        .WithMany("Instructors_Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Department", b =>
                {
                    b.HasOne("EntityFrameWork_Assignment.Models.Instructor", "InstructorManage")
                        .WithOne("DepartmentManage")
                        .HasForeignKey("EntityFrameWork_Assignment.Models.Department", "InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InstructorManage");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Instructor", b =>
                {
                    b.HasOne("EntityFrameWork_Assignment.Models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Stud_Course", b =>
                {
                    b.HasOne("EntityFrameWork_Assignment.Models.Course", "Course")
                        .WithMany("Course_Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Assignment.Models.Student", "Student")
                        .WithMany("Stud_Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Student", b =>
                {
                    b.HasOne("EntityFrameWork_Assignment.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Course", b =>
                {
                    b.Navigation("Course_Students");

                    b.Navigation("Courses_Inst");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Instructor", b =>
                {
                    b.Navigation("DepartmentManage")
                        .IsRequired();

                    b.Navigation("Instructors_Courses");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Student", b =>
                {
                    b.Navigation("Stud_Courses");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
