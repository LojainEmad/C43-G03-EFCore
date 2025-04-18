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
    [Migration("20250228070548_First Create All Tables")]
    partial class FirstCreateAllTables
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

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EntityFrameWork_Assignment.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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

                    b.Property<decimal?>("HourRate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("InstructorId");

                    b.ToTable("Instructors");
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

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<string>("LName")
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.HasKey("StudentId");

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
#pragma warning restore 612, 618
        }
    }
}
