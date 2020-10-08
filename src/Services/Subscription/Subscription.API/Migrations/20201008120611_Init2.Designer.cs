﻿// <auto-generated />
using System;
using EMS.Subscription_Services.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMS.Subscription_Services.API.Migrations
{
    [DbContext(typeof(SubscriptionContext))]
    [Migration("20201008120611_Init2")]
    partial class Init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMS.Subscription_Services.API.Context.Club", b =>
                {
                    b.Property<Guid>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClubId");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("EMS.Subscription_Services.API.Context.ClubSubscription", b =>
                {
                    b.Property<Guid>("SubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClubId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<int>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("SubscriptionId");

                    b.HasIndex("ClubId");

                    b.HasIndex("Name", "SubscriptionId")
                        .IsUnique();

                    b.ToTable("ClubSubscription");
                });

            modelBuilder.Entity("EMS.Subscription_Services.API.Context.ClubSubscription", b =>
                {
                    b.HasOne("EMS.Subscription_Services.API.Context.Club", "Club")
                        .WithMany("Subscriptions")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
