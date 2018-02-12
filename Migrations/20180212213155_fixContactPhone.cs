using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace askdotnetblog.Migrations
{
    public partial class fixContactPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactPone",
                table: "Vehicles",
                newName: "ContactPhone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactPhone",
                table: "Vehicles",
                newName: "ContactPone");
        }
    }
}
