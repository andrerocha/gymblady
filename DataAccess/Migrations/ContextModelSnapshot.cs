﻿// <auto-generated />
using DataAccess;
using Entities.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Academy", b =>
                {
                    b.Property<int>("IdAcademy")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<int>("IdTeam");

                    b.Property<bool>("Main");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("IdAcademy");

                    b.HasIndex("IdTeam");

                    b.ToTable("Academy");
                });

            modelBuilder.Entity("Entities.AcademyAddress", b =>
                {
                    b.Property<int>("IdAcademyAddress")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Complement");

                    b.Property<DateTime>("Created");

                    b.Property<int>("IdAcademy");

                    b.Property<int>("IdCity");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.Property<string>("Neighborhood");

                    b.Property<int>("Number");

                    b.Property<string>("ZipCode");

                    b.HasKey("IdAcademyAddress");

                    b.HasIndex("IdAcademy");

                    b.HasIndex("IdCity");

                    b.ToTable("AcademyAddress");
                });

            modelBuilder.Entity("Entities.AcademyPhone", b =>
                {
                    b.Property<int>("IdAcademyPhone")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AreaCode");

                    b.Property<int>("CountryCode");

                    b.Property<DateTime>("Created");

                    b.Property<int>("IdAcademy");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Number");

                    b.Property<int>("Type");

                    b.HasKey("IdAcademyPhone");

                    b.HasIndex("IdAcademy");

                    b.ToTable("AcademyPhone");
                });

            modelBuilder.Entity("Entities.City", b =>
                {
                    b.Property<int>("IdCity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("Created");

                    b.Property<int>("IdState");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("IdCity");

                    b.HasIndex("IdState");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Entities.Class", b =>
                {
                    b.Property<int>("IdClass")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<int>("IdAcademy");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("IdClass");

                    b.HasIndex("IdAcademy");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("Entities.Country", b =>
                {
                    b.Property<int>("IdCountry")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("IdCountry");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Entities.State", b =>
                {
                    b.Property<int>("IdState")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("Created");

                    b.Property<int>("IdCountry");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("IdState");

                    b.HasIndex("IdCountry");

                    b.ToTable("State");
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Property<int>("IdStudent")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AcceptedTerms");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("BloodType");

                    b.Property<DateTime>("Created");

                    b.Property<string>("DrugsDescription");

                    b.Property<string>("Email");

                    b.Property<bool>("HasHealthProblem");

                    b.Property<bool>("HasSurgery");

                    b.Property<string>("HelthProblemDescription");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("SurgeryDescription");

                    b.Property<string>("Surname");

                    b.Property<bool>("UseDrugs");

                    b.HasKey("IdStudent");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Entities.StudentAddress", b =>
                {
                    b.Property<int>("IdStudentAddress")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Complement");

                    b.Property<DateTime>("Created");

                    b.Property<int>("IdCity");

                    b.Property<int>("IdStudent");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.Property<string>("Neighborhood");

                    b.Property<int>("Number");

                    b.Property<string>("ZipCode");

                    b.HasKey("IdStudentAddress");

                    b.HasIndex("IdCity");

                    b.HasIndex("IdStudent");

                    b.ToTable("StudentAddress");
                });

            modelBuilder.Entity("Entities.StudentPhone", b =>
                {
                    b.Property<int>("IdStudentPhone")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AreaCode");

                    b.Property<int>("CountryCode");

                    b.Property<DateTime>("Created");

                    b.Property<int>("IdStudent");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Number");

                    b.Property<int>("Type");

                    b.HasKey("IdStudentPhone");

                    b.HasIndex("IdStudent");

                    b.ToTable("StudentPhone");
                });

            modelBuilder.Entity("Entities.Team", b =>
                {
                    b.Property<int>("IdTeam")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("IdTeam");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Entities.Academy", b =>
                {
                    b.HasOne("Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("IdTeam")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.AcademyAddress", b =>
                {
                    b.HasOne("Entities.Academy", "Academy")
                        .WithMany("Addresses")
                        .HasForeignKey("IdAcademy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("IdCity")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.AcademyPhone", b =>
                {
                    b.HasOne("Entities.Academy", "Academy")
                        .WithMany("Phones")
                        .HasForeignKey("IdAcademy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.City", b =>
                {
                    b.HasOne("Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("IdState")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Class", b =>
                {
                    b.HasOne("Entities.Academy", "Academy")
                        .WithMany()
                        .HasForeignKey("IdAcademy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.State", b =>
                {
                    b.HasOne("Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.StudentAddress", b =>
                {
                    b.HasOne("Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("IdCity")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.Student", "Student")
                        .WithMany("Addresses")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.StudentPhone", b =>
                {
                    b.HasOne("Entities.Student", "Student")
                        .WithMany("Phones")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
