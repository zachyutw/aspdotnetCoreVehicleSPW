using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace askdotnetblog.Migrations
{
    public partial class SeedingFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name, MakeID) VALUES ('Make1-Feature1',(SELECT ID FROM Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Features (Name, MakeID) VALUES ('Make1-Feature2',(SELECT ID FROM Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Features (Name, MakeID) VALUES ('Make1-Feature3',(SELECT ID FROM Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Features (Name, MakeID) VALUES ('Make2-Feature1',(SELECT ID FROM Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO Features (Name, MakeID) VALUES ('Make2-Feature2',(SELECT ID FROM Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO Features (Name, MakeID) VALUES ('Make2-Feature3',(SELECT ID FROM Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO Features (Name, MakeID) VALUES ('Make3-Feature1',(SELECT ID FROM Makes WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO Features (Name, MakeID) VALUES ('Make3-Feature2',(SELECT ID FROM Makes WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO Features (Name, MakeID) VALUES ('Make3-Feature3',(SELECT ID FROM Makes WHERE Name = 'Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("DELETE FROM Makes WHERE NAME IN('Make1','Make2','Make3')");
        }
    }
}
