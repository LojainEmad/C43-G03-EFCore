using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class onetoonerelationshipbetweendepartmentandinstructorinmanagerelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InsructorId",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments",
                column: "InstructorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_InstructorId",
                table: "Departments",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InstructorId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "InsructorId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Departments");
        }
    }
}
