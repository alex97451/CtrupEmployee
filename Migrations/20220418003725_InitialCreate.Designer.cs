﻿// <auto-generated />
using System;
using CtrlUpEmploye.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CtrlUpEmploye.Migrations
{
    [DbContext(typeof(CtrlUpContext))]
    [Migration("20220418003725_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("CtrlUpEmploye.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstMidName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CtrlUpEmploye.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Grade")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpecialiteID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("SpecialiteID");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("CtrlUpEmploye.Models.Specialite", b =>
                {
                    b.Property<int>("SpecialiteID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("SpecialiteID");

                    b.ToTable("Specialites");
                });

            modelBuilder.Entity("CtrlUpEmploye.Models.Enrollment", b =>
                {
                    b.HasOne("CtrlUpEmploye.Models.Employee", "Employee")
                        .WithMany("Enrollments")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("CtrlUpEmploye.Models.Specialite", "Specialite")
                        .WithMany("Enrollments")
                        .HasForeignKey("SpecialiteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Specialite");
                });

            modelBuilder.Entity("CtrlUpEmploye.Models.Employee", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("CtrlUpEmploye.Models.Specialite", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
