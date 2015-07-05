using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace WebApplication3.Migrations
{
    public partial class PhoneSettingCreate : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateSequence(
                name: "DefaultSequence",
                type: "bigint",
                startWith: 1L,
                incrementBy: 10);
            migration.CreateTable(
                name: "PhoneSpotting",
                columns: table => new
                {
                    Latitude = table.Column(type: "int", nullable: false),
                    Longitude = table.Column(type: "int", nullable: false),
                    Notes = table.Column(type: "nvarchar(max)", nullable: true),
                    PhoneManufacturer = table.Column(type: "nvarchar(max)", nullable: true),
                    PhoneModel = table.Column(type: "nvarchar(max)", nullable: true),
                    PhoneSpottingId = table.Column(type: "int", nullable: false),
                    SpotTime = table.Column(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneSpotting", x => x.PhoneSpottingId);
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropSequence("DefaultSequence");
            migration.DropTable("PhoneSpotting");
        }
    }
}
