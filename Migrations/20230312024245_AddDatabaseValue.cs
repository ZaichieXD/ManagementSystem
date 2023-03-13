using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDatabaseValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsModel_EmployeeModel_AssignedEmployeeEmployeeId",
                table: "ProjectsModel");

            migrationBuilder.DropIndex(
                name: "IX_ProjectsModel_AssignedEmployeeEmployeeId",
                table: "ProjectsModel");

            migrationBuilder.DropColumn(
                name: "AssignedEmployeeEmployeeId",
                table: "ProjectsModel");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "ProjectsModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectDescription",
                table: "ProjectsModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "ProjectsModel");

            migrationBuilder.DropColumn(
                name: "ProjectDescription",
                table: "ProjectsModel");

            migrationBuilder.AddColumn<int>(
                name: "AssignedEmployeeEmployeeId",
                table: "ProjectsModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsModel_AssignedEmployeeEmployeeId",
                table: "ProjectsModel",
                column: "AssignedEmployeeEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectsModel_EmployeeModel_AssignedEmployeeEmployeeId",
                table: "ProjectsModel",
                column: "AssignedEmployeeEmployeeId",
                principalTable: "EmployeeModel",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
