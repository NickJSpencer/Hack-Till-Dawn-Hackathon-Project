using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HackTillDawnProject.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UserToken");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserExternalLogin");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaim");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaim");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "UserRole",
                newName: "IX_UserRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "UserExternalLogin",
                newName: "IX_UserExternalLogin_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "UserClaim",
                newName: "IX_UserClaim_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "RoleClaim",
                newName: "IX_RoleClaim_RoleId");

            migrationBuilder.AddColumn<string>(
                name: "StaffId",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Roles",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserToken",
                table: "UserToken",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserExternalLogin",
                table: "UserExternalLogin",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaim",
                table: "UserClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaim",
                table: "RoleClaim",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "APIResultType",
                columns: table => new
                {
                    IdResultType = table.Column<Guid>(nullable: false),
                    APIName = table.Column<string>(nullable: true),
                    DateCreatedUtc = table.Column<DateTime>(nullable: false),
                    DateLastModifiedUtc = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APIResultType", x => x.IdResultType);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    IdContact = table.Column<Guid>(nullable: false),
                    ComChannel = table.Column<int>(nullable: true),
                    DateCreatedUtc = table.Column<DateTime>(nullable: false),
                    DateLastModifiedUtc = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.IdContact);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    IdEvent = table.Column<Guid>(nullable: false),
                    DateCreatedUtc = table.Column<DateTime>(nullable: false),
                    DateLastModifiedUtc = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EventEnd = table.Column<DateTime>(nullable: true),
                    EventStart = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.IdEvent);
                });

            migrationBuilder.CreateTable(
                name: "RegisteredDevice",
                columns: table => new
                {
                    IdRegisteredDevice = table.Column<Guid>(nullable: false),
                    DateCreatedUtc = table.Column<DateTime>(nullable: false),
                    DateLastModifiedUtc = table.Column<DateTime>(nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: false),
                    DeviceName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    RegisteredById = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredDevice", x => x.IdRegisteredDevice);
                    table.ForeignKey(
                        name: "FK_RegisteredDevice_User_RegisteredById",
                        column: x => x.RegisteredById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Channel",
                columns: table => new
                {
                    IdChannel = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EventId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channel", x => x.IdChannel);
                    table.ForeignKey(
                        name: "FK_Channel_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffEventIntermediate",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    DateCreatedUtc = table.Column<DateTime>(nullable: false),
                    DateLastModifiedUtc = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffEventIntermediate", x => new { x.ApplicationUserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_StaffEventIntermediate_User_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StaffEventIntermediate_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeviceEventIntermediate",
                columns: table => new
                {
                    IdRegisteredDeviceId = table.Column<Guid>(nullable: false),
                    IdEventId = table.Column<Guid>(nullable: false),
                    DateCreatedUtc = table.Column<DateTime>(nullable: false),
                    DateLastModifiedUtc = table.Column<DateTime>(nullable: false),
                    DeviceLocation = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceEventIntermediate", x => new { x.IdRegisteredDeviceId, x.IdEventId });
                    table.ForeignKey(
                        name: "FK_DeviceEventIntermediate_Event_IdEventId",
                        column: x => x.IdEventId,
                        principalTable: "Event",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeviceEventIntermediate_RegisteredDevice_IdRegisteredDeviceId",
                        column: x => x.IdRegisteredDeviceId,
                        principalTable: "RegisteredDevice",
                        principalColumn: "IdRegisteredDevice",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FootageStorage",
                columns: table => new
                {
                    IdFootageStorage = table.Column<Guid>(nullable: false),
                    APIResultTypeId = table.Column<Guid>(nullable: false),
                    DateCreatedUtc = table.Column<DateTime>(nullable: false),
                    DateLastModifiedUtc = table.Column<DateTime>(nullable: false),
                    DateTimeCaptureEndUtc = table.Column<DateTime>(nullable: false),
                    DateTimeCaptureStartUtc = table.Column<DateTime>(nullable: false),
                    FileLocation = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    RegisteredDeviceId = table.Column<Guid>(nullable: false),
                    Tags = table.Column<string>(nullable: true),
                    TriggerConfidencePercent = table.Column<decimal>(nullable: false),
                    TriggerDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootageStorage", x => x.IdFootageStorage);
                    table.ForeignKey(
                        name: "FK_FootageStorage_APIResultType_APIResultTypeId",
                        column: x => x.APIResultTypeId,
                        principalTable: "APIResultType",
                        principalColumn: "IdResultType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootageStorage_RegisteredDevice_RegisteredDeviceId",
                        column: x => x.RegisteredDeviceId,
                        principalTable: "RegisteredDevice",
                        principalColumn: "IdRegisteredDevice",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChannelContactIntermediate",
                columns: table => new
                {
                    IdChannelId = table.Column<Guid>(nullable: false),
                    IdContactId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelContactIntermediate", x => new { x.IdChannelId, x.IdContactId });
                    table.ForeignKey(
                        name: "FK_ChannelContactIntermediate_Channel_IdChannelId",
                        column: x => x.IdChannelId,
                        principalTable: "Channel",
                        principalColumn: "IdChannel",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChannelContactIntermediate_Contact_IdContactId",
                        column: x => x.IdContactId,
                        principalTable: "Contact",
                        principalColumn: "IdContact",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Channel_EventId",
                table: "Channel",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ChannelContactIntermediate_IdContactId",
                table: "ChannelContactIntermediate",
                column: "IdContactId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceEventIntermediate_IdEventId",
                table: "DeviceEventIntermediate",
                column: "IdEventId");

            migrationBuilder.CreateIndex(
                name: "IX_FootageStorage_APIResultTypeId",
                table: "FootageStorage",
                column: "APIResultTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FootageStorage_RegisteredDeviceId",
                table: "FootageStorage",
                column: "RegisteredDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredDevice_RegisteredById",
                table: "RegisteredDevice",
                column: "RegisteredById");

            migrationBuilder.CreateIndex(
                name: "IX_StaffEventIntermediate_EventId",
                table: "StaffEventIntermediate",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaim_Roles_RoleId",
                table: "RoleClaim",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaim_User_UserId",
                table: "UserClaim",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExternalLogin_User_UserId",
                table: "UserExternalLogin",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Roles_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToken_User_UserId",
                table: "UserToken",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaim_Roles_RoleId",
                table: "RoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaim_User_UserId",
                table: "UserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExternalLogin_User_UserId",
                table: "UserExternalLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Roles_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToken_User_UserId",
                table: "UserToken");

            migrationBuilder.DropTable(
                name: "ChannelContactIntermediate");

            migrationBuilder.DropTable(
                name: "DeviceEventIntermediate");

            migrationBuilder.DropTable(
                name: "FootageStorage");

            migrationBuilder.DropTable(
                name: "StaffEventIntermediate");

            migrationBuilder.DropTable(
                name: "Channel");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "APIResultType");

            migrationBuilder.DropTable(
                name: "RegisteredDevice");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserToken",
                table: "UserToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserExternalLogin",
                table: "UserExternalLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaim",
                table: "UserClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaim",
                table: "RoleClaim");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Roles");

            migrationBuilder.RenameTable(
                name: "UserToken",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "UserExternalLogin",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaim",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "RoleClaim",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserExternalLogin_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaim_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaim_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
