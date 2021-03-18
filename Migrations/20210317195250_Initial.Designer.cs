﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempleToursProject.Models;

namespace TempleToursProject.Migrations
{
    [DbContext(typeof(TourDbContext))]
    [Migration("20210317195250_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12");

            modelBuilder.Entity("TempleToursProject.Models.GroupInfo", b =>
                {
                    b.Property<int>("GroupInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("SelectedAppointment")
                        .HasColumnType("TEXT");

                    b.HasKey("GroupInfoId");

                    b.ToTable("GroupInfo");
                });

            modelBuilder.Entity("TempleToursProject.Models.TimeSlots", b =>
                {
                    b.Property<int>("TimeSlotsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Scheduled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TimeSlotDay")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeSlotTime")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeSlotsId");

                    b.ToTable("TimeSlots");
                });
#pragma warning restore 612, 618
        }
    }
}