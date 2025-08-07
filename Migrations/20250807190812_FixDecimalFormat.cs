using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_FreamWork.Migrations
{
    /// <inheritdoc />
    public partial class FixDecimalFormat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "netSalary",
                schema: "dbo",
                table: "Employees",
                newName: "NetSalary");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetSalary",
                schema: "dbo",
                table: "Employees",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Gross_Salary",
                schema: "dbo",
                table: "Employees",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NetSalary",
                schema: "dbo",
                table: "Employees",
                newName: "netSalary");

            migrationBuilder.AlterColumn<decimal>(
                name: "netSalary",
                schema: "dbo",
                table: "Employees",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Gross_Salary",
                schema: "dbo",
                table: "Employees",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");
        }
    }
}
