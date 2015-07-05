using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace WebApplication3.Migrations
{
    public partial class FixLatLongType : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.AlterColumn(
                name: "Latitude",
                table: "PhoneSpotting",
                type: "float",
                nullable: false);
            migration.AlterColumn(
                name: "Longitude",
                table: "PhoneSpotting",
                type: "float",
                nullable: false);
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.AlterColumn(
                name: "Latitude",
                table: "PhoneSpotting",
                type: "int",
                nullable: false);
            migration.AlterColumn(
                name: "Longitude",
                table: "PhoneSpotting",
                type: "int",
                nullable: false);
        }
    }
}
