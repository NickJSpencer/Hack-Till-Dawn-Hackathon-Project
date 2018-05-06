using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HackTillDawnProject.Models;
using Microsoft.AspNetCore.Identity;

namespace HackTillDawnProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<RegisteredDevice> RegisteredDevice { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Channel> Channel { get; set; }
        public virtual DbSet<DeviceEventIntermediate> DeviceEventIntermediate { get; set; }
        public virtual DbSet<ChannelContactIntermediate> ChannelContactIntermediate { get; set; }
        public virtual DbSet<FootageStorage> FootageStorage { get; set; }
        public virtual DbSet<StaffEventIntermediate> StaffEventIntermediate { get; set; }
        public virtual DbSet<APIResultType> APIResultType { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("User");
            builder.Entity<IdentityRole<string>>().ToTable("Roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRole");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserToken");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserExternalLogin");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim");

            builder.Entity<RegisteredDevice>(entity =>
            {
                entity.HasKey(e => e.IdRegisteredDevice);

                entity.HasOne(e => e.RegisteredBy)
                    .WithMany(e => e.RegisteredDevices)
                    .HasForeignKey(e => e.RegisteredById);

            });
            builder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.IdContact);

                
            });
            builder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.IdEvent);
            });
            builder.Entity<Channel>(entity =>
            {
                entity.HasKey(e => e.IdChannel);

                entity.HasOne(e => e.Event)
                    .WithMany(e => e.Channels)
                    .HasForeignKey(e => e.EventId);
            });
            builder.Entity<DeviceEventIntermediate>(entity =>
            {
                entity.HasKey(e => new { e.IdRegisteredDeviceId, e.IdEventId });

                entity.HasOne(e => e.RegisteredDevice)
                    .WithMany(e => e.DeviceEventIntermediates)
                    .HasForeignKey(e => e.IdRegisteredDeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(e => e.Event)
                    .WithMany(e => e.DeviceEventIntermediates)
                    .HasForeignKey(e => e.IdEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
            builder.Entity<ChannelContactIntermediate>(entity =>
            {
                entity.HasKey(e => new { e.IdChannelId, e.IdContactId });

                entity.HasOne(e => e.Channel)
                    .WithMany(e => e.ChannelContactIntermediates)
                    .HasForeignKey(e => e.IdChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(e => e.Contact)
                    .WithMany(e => e.ChannelContactIntermediates)
                    .HasForeignKey(e => e.IdContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
            builder.Entity<FootageStorage>(entity =>
            {
                entity.HasKey(e => e.IdFootageStorage);

                entity.HasOne(e => e.APIResultType)
                    .WithMany(e => e.FootageStorages)
                    .HasForeignKey(e => e.APIResultTypeId);

                entity.HasOne(e => e.RegisteredDevice)
                    .WithMany(e => e.FootageStored)
                    .HasForeignKey(e => e.RegisteredDeviceId);
            });
            builder.Entity<StaffEventIntermediate>(entity =>
            {
                entity.HasKey(e => new { e.ApplicationUserId, e.EventId });

                entity.HasOne(e => e.ApplicationUser)
                    .WithMany(e => e.StaffEventIntermediates)
                    .HasForeignKey(e => e.ApplicationUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(e => e.Event)
                    .WithMany(e => e.StaffEventIntermediates)
                    .HasForeignKey(e => e.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
            builder.Entity<APIResultType>(entity =>
            {
                entity.HasKey(e => e.IdResultType);
            });
        }
    }
}
