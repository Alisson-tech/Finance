using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finance.Migrations
{
    /// <inheritdoc />
    public partial class CreateTypeAndAddBaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesValues_Expenses_ExpensesId",
                table: "ExpensesValues");

            migrationBuilder.DropForeignKey(
                name: "FK_RevenueValues_Revenue_RevenueId",
                table: "RevenueValues");

            migrationBuilder.DropIndex(
                name: "IX_RevenueValues_RevenueId",
                table: "RevenueValues");

            migrationBuilder.DropIndex(
                name: "IX_ExpensesValues_ExpensesId",
                table: "ExpensesValues");

            migrationBuilder.DropColumn(
                name: "RevenueId",
                table: "RevenueValues");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Revenue");

            migrationBuilder.DropColumn(
                name: "ExpensesId",
                table: "ExpensesValues");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "DateExpired",
                table: "ExpensesValues",
                newName: "DateModified");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "RevenueValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "RevenueValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "RevenueValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Revenue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Revenue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Revenue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ExpensesValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "ExpensesValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Expenses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ExpensiveType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpensiveType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RevenueTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevenueTypes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpensiveType_Id",
                table: "Expenses",
                column: "Id",
                principalTable: "ExpensiveType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesValues_Expenses_Id",
                table: "ExpensesValues",
                column: "Id",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Revenue_RevenueTypes_Id",
                table: "Revenue",
                column: "Id",
                principalTable: "RevenueTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RevenueValues_Revenue_Id",
                table: "RevenueValues",
                column: "Id",
                principalTable: "Revenue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpensiveType_Id",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesValues_Expenses_Id",
                table: "ExpensesValues");

            migrationBuilder.DropForeignKey(
                name: "FK_Revenue_RevenueTypes_Id",
                table: "Revenue");

            migrationBuilder.DropForeignKey(
                name: "FK_RevenueValues_Revenue_Id",
                table: "RevenueValues");

            migrationBuilder.DropTable(
                name: "ExpensiveType");

            migrationBuilder.DropTable(
                name: "RevenueTypes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "RevenueValues");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "RevenueValues");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "RevenueValues");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Revenue");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Revenue");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Revenue");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ExpensesValues");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "ExpensesValues");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "ExpensesValues",
                newName: "DateExpired");

            migrationBuilder.AddColumn<Guid>(
                name: "RevenueId",
                table: "RevenueValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Revenue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ExpensesId",
                table: "ExpensesValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RevenueValues_RevenueId",
                table: "RevenueValues",
                column: "RevenueId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesValues_ExpensesId",
                table: "ExpensesValues",
                column: "ExpensesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesValues_Expenses_ExpensesId",
                table: "ExpensesValues",
                column: "ExpensesId",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RevenueValues_Revenue_RevenueId",
                table: "RevenueValues",
                column: "RevenueId",
                principalTable: "Revenue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
