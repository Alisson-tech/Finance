using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finance.Migrations
{
    /// <inheritdoc />
    public partial class foreignKeyEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "RevenueId",
                table: "RevenueValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "Revenue",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ExpensesId",
                table: "ExpensesValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_RevenueValues_RevenueId",
                table: "RevenueValues",
                column: "RevenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Revenue_TypeId",
                table: "Revenue",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesValues_ExpensesId",
                table: "ExpensesValues",
                column: "ExpensesId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_TypeId",
                table: "Expenses",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpensiveType_TypeId",
                table: "Expenses",
                column: "TypeId",
                principalTable: "ExpensiveType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesValues_Expenses_ExpensesId",
                table: "ExpensesValues",
                column: "ExpensesId",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Revenue_RevenueTypes_TypeId",
                table: "Revenue",
                column: "TypeId",
                principalTable: "RevenueTypes",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpensiveType_TypeId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesValues_Expenses_ExpensesId",
                table: "ExpensesValues");

            migrationBuilder.DropForeignKey(
                name: "FK_Revenue_RevenueTypes_TypeId",
                table: "Revenue");

            migrationBuilder.DropForeignKey(
                name: "FK_RevenueValues_Revenue_RevenueId",
                table: "RevenueValues");

            migrationBuilder.DropIndex(
                name: "IX_RevenueValues_RevenueId",
                table: "RevenueValues");

            migrationBuilder.DropIndex(
                name: "IX_Revenue_TypeId",
                table: "Revenue");

            migrationBuilder.DropIndex(
                name: "IX_ExpensesValues_ExpensesId",
                table: "ExpensesValues");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_TypeId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "RevenueId",
                table: "RevenueValues");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Revenue");

            migrationBuilder.DropColumn(
                name: "ExpensesId",
                table: "ExpensesValues");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Expenses");

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
    }
}
