using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bwire.Migrations
{
    public partial class Update_Index_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Warehouses");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Areas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Areas");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Warehouses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Warehouses",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Warehouses",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Warehouses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Warehouses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Warehouses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Warehouses",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Warehouses",
                type: "int",
                nullable: true);
        }
    }
}
