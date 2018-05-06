﻿// <auto-generated />
using HackTillDawnProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace HackTillDawnProject.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180506001913_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HackTillDawnProject.Models.APIResultType", b =>
                {
                    b.Property<Guid>("IdResultType")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("APIName");

                    b.Property<DateTime>("DateCreatedUtc");

                    b.Property<DateTime>("DateLastModifiedUtc");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("IdResultType");

                    b.ToTable("APIResultType");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("StaffId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.Channel", b =>
                {
                    b.Property<Guid>("IdChannel")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("EventId");

                    b.Property<string>("Name");

                    b.HasKey("IdChannel");

                    b.HasIndex("EventId");

                    b.ToTable("Channel");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.ChannelContactIntermediate", b =>
                {
                    b.Property<Guid>("IdChannelId");

                    b.Property<Guid>("IdContactId");

                    b.HasKey("IdChannelId", "IdContactId");

                    b.HasIndex("IdContactId");

                    b.ToTable("ChannelContactIntermediate");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.Contact", b =>
                {
                    b.Property<Guid>("IdContact")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ComChannel");

                    b.Property<DateTime>("DateCreatedUtc");

                    b.Property<DateTime>("DateLastModifiedUtc");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Role");

                    b.HasKey("IdContact");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.DeviceEventIntermediate", b =>
                {
                    b.Property<Guid>("IdRegisteredDeviceId");

                    b.Property<Guid>("IdEventId");

                    b.Property<DateTime>("DateCreatedUtc");

                    b.Property<DateTime>("DateLastModifiedUtc");

                    b.Property<string>("DeviceLocation");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("IdRegisteredDeviceId", "IdEventId");

                    b.HasIndex("IdEventId");

                    b.ToTable("DeviceEventIntermediate");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.Event", b =>
                {
                    b.Property<Guid>("IdEvent")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreatedUtc");

                    b.Property<DateTime>("DateLastModifiedUtc");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("EventEnd");

                    b.Property<DateTime?>("EventStart");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("IdEvent");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.FootageStorage", b =>
                {
                    b.Property<Guid>("IdFootageStorage")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("APIResultTypeId");

                    b.Property<DateTime>("DateCreatedUtc");

                    b.Property<DateTime>("DateLastModifiedUtc");

                    b.Property<DateTime>("DateTimeCaptureEndUtc");

                    b.Property<DateTime>("DateTimeCaptureStartUtc");

                    b.Property<string>("FileLocation");

                    b.Property<string>("FileName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("RegisteredDeviceId");

                    b.Property<string>("Tags");

                    b.Property<decimal>("TriggerConfidencePercent");

                    b.Property<string>("TriggerDescription");

                    b.HasKey("IdFootageStorage");

                    b.HasIndex("APIResultTypeId");

                    b.HasIndex("RegisteredDeviceId");

                    b.ToTable("FootageStorage");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.RegisteredDevice", b =>
                {
                    b.Property<Guid>("IdRegisteredDevice")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreatedUtc");

                    b.Property<DateTime>("DateLastModifiedUtc");

                    b.Property<DateTime>("DateRegistered");

                    b.Property<string>("DeviceName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("RegisteredById");

                    b.HasKey("IdRegisteredDevice");

                    b.HasIndex("RegisteredById");

                    b.ToTable("RegisteredDevice");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.StaffEventIntermediate", b =>
                {
                    b.Property<string>("ApplicationUserId");

                    b.Property<Guid>("EventId");

                    b.Property<DateTime>("DateCreatedUtc");

                    b.Property<DateTime>("DateLastModifiedUtc");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("ApplicationUserId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("StaffEventIntermediate");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<string>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserExternalLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole<string>");


                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator().HasValue("IdentityRole");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.Channel", b =>
                {
                    b.HasOne("HackTillDawnProject.Models.Event", "Event")
                        .WithMany("Channels")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HackTillDawnProject.Models.ChannelContactIntermediate", b =>
                {
                    b.HasOne("HackTillDawnProject.Models.Channel", "Channel")
                        .WithMany("ChannelContactIntermediates")
                        .HasForeignKey("IdChannelId");

                    b.HasOne("HackTillDawnProject.Models.Contact", "Contact")
                        .WithMany("ChannelContactIntermediates")
                        .HasForeignKey("IdContactId");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.DeviceEventIntermediate", b =>
                {
                    b.HasOne("HackTillDawnProject.Models.Event", "Event")
                        .WithMany("DeviceEventIntermediates")
                        .HasForeignKey("IdEventId");

                    b.HasOne("HackTillDawnProject.Models.RegisteredDevice", "RegisteredDevice")
                        .WithMany("DeviceEventIntermediates")
                        .HasForeignKey("IdRegisteredDeviceId");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.FootageStorage", b =>
                {
                    b.HasOne("HackTillDawnProject.Models.APIResultType", "APIResultType")
                        .WithMany("FootageStorages")
                        .HasForeignKey("APIResultTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HackTillDawnProject.Models.RegisteredDevice", "RegisteredDevice")
                        .WithMany("FootageStored")
                        .HasForeignKey("RegisteredDeviceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HackTillDawnProject.Models.RegisteredDevice", b =>
                {
                    b.HasOne("HackTillDawnProject.Models.ApplicationUser", "RegisteredBy")
                        .WithMany("RegisteredDevices")
                        .HasForeignKey("RegisteredById");
                });

            modelBuilder.Entity("HackTillDawnProject.Models.StaffEventIntermediate", b =>
                {
                    b.HasOne("HackTillDawnProject.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("StaffEventIntermediates")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("HackTillDawnProject.Models.Event", "Event")
                        .WithMany("StaffEventIntermediates")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HackTillDawnProject.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HackTillDawnProject.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HackTillDawnProject.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HackTillDawnProject.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
