using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.SqlServer.Metadata;

namespace EF7BooleanDefaultValue.Migrations
{
    public partial class AddTheThing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Thing",
                columns: table => new
                {
                    Id = table.Column<int>(isNullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerIdentityStrategy.IdentityColumn),
                    FavouriteNumber = table.Column<int>(isNullable: false, defaultValue: 42),
                    IsDeleted = table.Column<bool>(isNullable: false, defaultValue: false),
                    Name = table.Column<string>(isNullable: false, defaultValue: "n/a")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thing", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Thing");
        }
    }
}
