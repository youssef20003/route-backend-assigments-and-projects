using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_assignment_2.Migrations
{
    /// <inheritdoc />
    public partial class testbuild2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_CourseID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_CourseID",
                table: "Stud_Courses");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Stud_Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_Student_ID",
                table: "Stud_Courses",
                column: "Student_ID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_Student_ID",
                table: "Stud_Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Stud_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_CourseID",
                table: "Stud_Courses",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_CourseID",
                table: "Stud_Courses",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
