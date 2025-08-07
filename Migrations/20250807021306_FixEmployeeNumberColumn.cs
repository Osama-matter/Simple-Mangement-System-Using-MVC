using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_FreamWork.Migrations
{
    /// <inheritdoc />
    public partial class FixEmployeeNumberColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Employee_Nuumber",
                schema: "dbo",
                table: "Employees",
                newName: "Employee_Number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Employee_Number",
                schema: "dbo",
                table: "Employees",
                newName: "Employee_Nuumber");
        }
    }
}
