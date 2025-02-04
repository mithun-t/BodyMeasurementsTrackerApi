﻿// <auto-generated />
using System;
using BodyMeasurementsTrackerApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BodyMeasurementsTrackerApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250204172500_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("BodyMeasurementsTrackerApi.Models.Entities.BodyMeasurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Biceps")
                        .HasColumnType("REAL");

                    b.Property<double>("BodyFatPercentage")
                        .HasColumnType("REAL");

                    b.Property<double>("BodyWeight")
                        .HasColumnType("REAL");

                    b.Property<double?>("Calves")
                        .HasColumnType("REAL");

                    b.Property<double?>("Chest")
                        .HasColumnType("REAL");

                    b.Property<double?>("Forearm")
                        .HasColumnType("REAL");

                    b.Property<double?>("Hips")
                        .HasColumnType("REAL");

                    b.Property<DateOnly>("MeasuredDate")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Neck")
                        .HasColumnType("REAL");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProgressPicture")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Shoulder")
                        .HasColumnType("REAL");

                    b.Property<double?>("Thighs")
                        .HasColumnType("REAL");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Waist")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BodyMeasurements");
                });

            modelBuilder.Entity("BodyMeasurementsTrackerApi.Models.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BodyMeasurementsTrackerApi.Models.Entities.BodyMeasurement", b =>
                {
                    b.HasOne("BodyMeasurementsTrackerApi.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
