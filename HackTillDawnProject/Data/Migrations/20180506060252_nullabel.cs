using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HackTillDawnProject.Data.Migrations
{
    public partial class nullabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TriggerConfidencePercent",
                table: "FootageStorage",
                nullable: true,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TriggerConfidencePercent",
                table: "FootageStorage",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);
        }
    }
}
