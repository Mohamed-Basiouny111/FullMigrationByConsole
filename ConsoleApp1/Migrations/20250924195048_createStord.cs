using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class createStord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string str = @"CREATE PROCEDURE GetEmployeesByDeptId
                             @DeptId INT
                         AS
                         BEGIN
                             SET NOCOUNT ON;
                         
                             SELECT *
                             FROM Employee e
                             WHERE e.DeptId = @DeptId;
                         END";
            migrationBuilder.Sql(str);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
