using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace EF7BooleanDefaultValue.Migrations
{
    public partial class Nothing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Thing",
                isNullable: false,
                defaultValue: false);
            migrationBuilder.AlterColumn<int>(
                name: "FavouriteNumber",
                table: "Thing",
                isNullable: false,
                defaultValue: 42);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Thing",
                isNullable: false,
                defaultValue: false);
            migrationBuilder.AlterColumn<int>(
                name: "FavouriteNumber",
                table: "Thing",
                isNullable: false,
                defaultValue: 42);
        }
    }
}
