﻿// <auto-generated />
using System;
using EMS.Event_Services.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMS.Event_Services.API.Migrations
{
    [DbContext(typeof(EventContext))]
    partial class EventContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.Club", b =>
                {
                    b.Property<Guid>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClubId");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.ClubSubscription", b =>
                {
                    b.Property<Guid>("ClubSubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClubId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClubSubscriptionId");

                    b.HasIndex("ClubId");

                    b.ToTable("ClubSubscription");
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.Event", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClubId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("ClubId", "Name")
                        .IsUnique();

                    b.ToTable("Event");
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.EventPrice", b =>
                {
                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClubSubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("EventId", "ClubSubscriptionId");

                    b.HasIndex("ClubSubscriptionId");

                    b.ToTable("EventPrice");
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.Instructor", b =>
                {
                    b.Property<Guid>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClubId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClubId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("InstructorId");

                    b.HasIndex("ClubId");

                    b.HasIndex("ClubId1");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.InstructorForEvent", b =>
                {
                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InstructorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EventId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("InstructorForEvent");
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.Room", b =>
                {
                    b.Property<Guid>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClubId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoomId");

                    b.HasIndex("ClubId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.RoomEvent", b =>
                {
                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EventId", "RoomId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomEvent");
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.ClubSubscription", b =>
                {
                    b.HasOne("EMS.Event_Services.API.Context.Model.Club", null)
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.Event", b =>
                {
                    b.HasOne("EMS.Event_Services.API.Context.Model.Club", null)
                        .WithMany("Events")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.EventPrice", b =>
                {
                    b.HasOne("EMS.Event_Services.API.Context.Model.ClubSubscription", "ClubSubscription")
                        .WithMany("EventPrices")
                        .HasForeignKey("ClubSubscriptionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EMS.Event_Services.API.Context.Model.Event", "Event")
                        .WithMany("EventPrices")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.Instructor", b =>
                {
                    b.HasOne("EMS.Event_Services.API.Context.Model.Club", null)
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EMS.Event_Services.API.Context.Model.Club", null)
                        .WithMany("Instructors")
                        .HasForeignKey("ClubId1");
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.InstructorForEvent", b =>
                {
                    b.HasOne("EMS.Event_Services.API.Context.Model.Event", "Event")
                        .WithMany("InstructorForEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EMS.Event_Services.API.Context.Model.Instructor", "Instructor")
                        .WithMany("InstructorForEvents")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.Room", b =>
                {
                    b.HasOne("EMS.Event_Services.API.Context.Model.Club", null)
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.Event_Services.API.Context.Model.RoomEvent", b =>
                {
                    b.HasOne("EMS.Event_Services.API.Context.Model.Event", "Event")
                        .WithMany("Locations")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EMS.Event_Services.API.Context.Model.Room", "Room")
                        .WithMany("Locations")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
