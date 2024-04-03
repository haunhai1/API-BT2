﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentCourses.Data;

#nullable disable

namespace API_BUOI2.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentCourses.Models.Courses", b =>
                {
                    b.Property<Guid?>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = new Guid("9250d994-2558-4573-8465-417248667051"),
                            CourseName = "Toán",
                            Description = "Giúp bạn thông minh hơn:))"
                        },
                        new
                        {
                            CourseId = new Guid("88738493-3a85-4443-8f6a-313453432192"),
                            CourseName = "Ngữ Văn",
                            Description = "Sao không thử thả vần thơ vào nhỉ, nếu cùng thì 2 ta cùng vần với nhau"
                        });
                });

            modelBuilder.Entity("StudentCourses.Models.Student", b =>
                {
                    b.Property<Guid?>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("e2397972-8743-431a-9482-60292f08320e"),
                            Name = "Võ Hoàng Việt"
                        },
                        new
                        {
                            StudentId = new Guid("4e79044a-988d-4488-97b7-3e474e4340d2"),
                            Name = "Nguyễn Phạm Phương Linh"
                        });
                });

            modelBuilder.Entity("StudentCourses.Models.StudentCourses", b =>
                {
                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CoursesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId", "CoursesId");

                    b.HasIndex("CoursesId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("e2397972-8743-431a-9482-60292f08320e"),
                            CoursesId = new Guid("88738493-3a85-4443-8f6a-313453432192")
                        },
                        new
                        {
                            StudentId = new Guid("4e79044a-988d-4488-97b7-3e474e4340d2"),
                            CoursesId = new Guid("9250d994-2558-4573-8465-417248667051")
                        });
                });

            modelBuilder.Entity("StudentCourses.Models.StudentCourses", b =>
                {
                    b.HasOne("StudentCourses.Models.Courses", "Courses")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentCourses.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentCourses.Models.Courses", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("StudentCourses.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
