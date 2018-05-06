using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HackTillDawnProject.Data.Migrations
{
    public partial class morecolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlaggedForDeletionUtc",
                table: "StaffEventIntermediate",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInactivatedUtc",
                table: "StaffEventIntermediate",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlaggedForDeletionUtc",
                table: "RegisteredDevice",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInactivatedUtc",
                table: "RegisteredDevice",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlaggedForDeletionUtc",
                table: "FootageStorage",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInactivatedUtc",
                table: "FootageStorage",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlaggedForDeletionUtc",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInactivatedUtc",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlaggedForDeletionUtc",
                table: "DeviceEventIntermediate",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInactivatedUtc",
                table: "DeviceEventIntermediate",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlaggedForDeletionUtc",
                table: "Contact",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInactivatedUtc",
                table: "Contact",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreatedUtc",
                table: "ChannelContactIntermediate",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlaggedForDeletionUtc",
                table: "ChannelContactIntermediate",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInactivatedUtc",
                table: "ChannelContactIntermediate",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateLastModifiedUtc",
                table: "ChannelContactIntermediate",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ChannelContactIntermediate",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ChannelContactIntermediate",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreatedUtc",
                table: "Channel",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlaggedForDeletionUtc",
                table: "Channel",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInactivatedUtc",
                table: "Channel",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateLastModifiedUtc",
                table: "Channel",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Channel",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Channel",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlaggedForDeletionUtc",
                table: "APIResultType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInactivatedUtc",
                table: "APIResultType",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateFlaggedForDeletionUtc",
                table: "StaffEventIntermediate");

            migrationBuilder.DropColumn(
                name: "DateInactivatedUtc",
                table: "StaffEventIntermediate");

            migrationBuilder.DropColumn(
                name: "DateFlaggedForDeletionUtc",
                table: "RegisteredDevice");

            migrationBuilder.DropColumn(
                name: "DateInactivatedUtc",
                table: "RegisteredDevice");

            migrationBuilder.DropColumn(
                name: "DateFlaggedForDeletionUtc",
                table: "FootageStorage");

            migrationBuilder.DropColumn(
                name: "DateInactivatedUtc",
                table: "FootageStorage");

            migrationBuilder.DropColumn(
                name: "DateFlaggedForDeletionUtc",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "DateInactivatedUtc",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "DateFlaggedForDeletionUtc",
                table: "DeviceEventIntermediate");

            migrationBuilder.DropColumn(
                name: "DateInactivatedUtc",
                table: "DeviceEventIntermediate");

            migrationBuilder.DropColumn(
                name: "DateFlaggedForDeletionUtc",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "DateInactivatedUtc",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "DateCreatedUtc",
                table: "ChannelContactIntermediate");

            migrationBuilder.DropColumn(
                name: "DateFlaggedForDeletionUtc",
                table: "ChannelContactIntermediate");

            migrationBuilder.DropColumn(
                name: "DateInactivatedUtc",
                table: "ChannelContactIntermediate");

            migrationBuilder.DropColumn(
                name: "DateLastModifiedUtc",
                table: "ChannelContactIntermediate");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ChannelContactIntermediate");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ChannelContactIntermediate");

            migrationBuilder.DropColumn(
                name: "DateCreatedUtc",
                table: "Channel");

            migrationBuilder.DropColumn(
                name: "DateFlaggedForDeletionUtc",
                table: "Channel");

            migrationBuilder.DropColumn(
                name: "DateInactivatedUtc",
                table: "Channel");

            migrationBuilder.DropColumn(
                name: "DateLastModifiedUtc",
                table: "Channel");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Channel");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Channel");

            migrationBuilder.DropColumn(
                name: "DateFlaggedForDeletionUtc",
                table: "APIResultType");

            migrationBuilder.DropColumn(
                name: "DateInactivatedUtc",
                table: "APIResultType");
        }
    }
}
