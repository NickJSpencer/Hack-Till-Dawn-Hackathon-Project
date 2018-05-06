using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HackTillDawnProject.Data.Migrations
{
    public partial class hfhhf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeviceName",
                table: "RegisteredDevice",
                newName: "DeviceIdName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeviceIdName",
                table: "RegisteredDevice",
                newName: "DeviceName");
        }
    }
}
