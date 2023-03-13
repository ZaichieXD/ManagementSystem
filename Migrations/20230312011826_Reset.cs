using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Reset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsModel_EmployeeModel_InCharge",
                table: "ProjectsModel");

            migrationBuilder.DropIndex(
                name: "IX_ProjectsModel_InCharge",
                table: "ProjectsModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeModel",
                table: "EmployeeModel");

            migrationBuilder.AlterColumn<string>(
                name: "InCharge",
                table: "ProjectsModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssignedEmployeeEmployeeId",
                table: "ProjectsModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "EmployeeModel",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeModel",
                table: "EmployeeModel",
                column: "EmployeeId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsModel_EmployeeModel_AssignedEmployeeEmployeeId",
                table: "ProjectsModel");

            migrationBuilder.DropIndex(
                name: "IX_ProjectsModel_AssignedEmployeeEmployeeId",
                table: "ProjectsModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeModel",
                table: "EmployeeModel");

            migrationBuilder.DropColumn(
                name: "AssignedEmployeeEmployeeId",
                table: "ProjectsModel");

            migrationBuilder.AlterColumn<string>(
                name: "InCharge",
                table: "ProjectsModel",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "EmployeeModel",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeModel",
                table: "EmployeeModel",
                column: "FirstName");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsModel_InCharge",
                table: "ProjectsModel",
                column: "InCharge");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectsModel_EmployeeModel_InCharge",
                table: "ProjectsModel",
                column: "InCharge",
                principalTable: "EmployeeModel",
                principalColumn: "FirstName");
        }
    }
}
