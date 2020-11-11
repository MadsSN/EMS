﻿// <auto-generated />
using System;
using EMS.Permission_Services.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMS.Permission_Services.API.Migrations
{
    [DbContext(typeof(PermissionContext))]
    [Migration("20201021115449_StripeInit")]
    partial class StripeInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMS.Permission_Services.API.Context.Model.Club", b =>
                {
                    b.Property<Guid>("ClubId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClubId");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("EMS.Permission_Services.API.Context.Model.Role", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClubId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClubSubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserRole")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "ClubId");

                    b.HasIndex("ClubId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("EMS.Permission_Services.API.Context.Model.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StripeCustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EMS.Permission_Services.API.Context.Model.Role", b =>
                {
                    b.HasOne("EMS.Permission_Services.API.Context.Model.Club", "Club")
                        .WithMany("Users")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EMS.Permission_Services.API.Context.Model.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
