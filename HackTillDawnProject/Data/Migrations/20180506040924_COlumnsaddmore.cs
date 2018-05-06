using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HackTillDawnProject.Data.Migrations
{
    public partial class COlumnsaddmore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateReadUtc",
                table: "FootageStorage",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsReviewed",
                table: "FootageStorage",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ReviewedById",
                table: "FootageStorage",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FootageStorage_ReviewedById",
                table: "FootageStorage",
                column: "ReviewedById");

            migrationBuilder.AddForeignKey(
                name: "FK_FootageStorage_User_ReviewedById",
                table: "FootageStorage",
                column: "ReviewedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootageStorage_User_ReviewedById",
                table: "FootageStorage");

            migrationBuilder.DropIndex(
                name: "IX_FootageStorage_ReviewedById",
                table: "FootageStorage");

            migrationBuilder.DropColumn(
                name: "DateReadUtc",
                table: "FootageStorage");

            migrationBuilder.DropColumn(
                name: "IsReviewed",
                table: "FootageStorage");

            migrationBuilder.DropColumn(
                name: "ReviewedById",
                table: "FootageStorage");
        }
    }
}
