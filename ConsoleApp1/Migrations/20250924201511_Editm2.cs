using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class Editm2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetail_Employee_EmployeeId",
                table: "EmployeeDetail");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetail_EmployeeId",
                table: "EmployeeDetail");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeDetail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeDetail",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetail_EmployeeId",
                table: "EmployeeDetail",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetail_Employee_EmployeeId",
                table: "EmployeeDetail",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId");
        }
    }
}
