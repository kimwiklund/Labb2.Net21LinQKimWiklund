using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2.Net21LinQKimWiklund.Migrations
{
    public partial class FirstCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "SchoolClasses",
                columns: table => new
                {
                    SchoolClassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolClassName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClasses", x => x.SchoolClassId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    fkCourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teachers_Courses_fkCourseId",
                        column: x => x.fkCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolClassCourses",
                columns: table => new
                {
                    SchoolClassCourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fkCourseId = table.Column<int>(nullable: false),
                    fkSchoolClassId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClassCourses", x => x.SchoolClassCourseId);
                    table.ForeignKey(
                        name: "FK_SchoolClassCourses_Courses_fkCourseId",
                        column: x => x.fkCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolClassCourses_SchoolClasses_fkSchoolClassId",
                        column: x => x.fkSchoolClassId,
                        principalTable: "SchoolClasses",
                        principalColumn: "SchoolClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    fkSchoolClassId = table.Column<int>(nullable: false),
                    fkStudentTeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_SchoolClasses_fkSchoolClassId",
                        column: x => x.fkSchoolClassId,
                        principalTable: "SchoolClasses",
                        principalColumn: "SchoolClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName" },
                values: new object[,]
                {
                    { 1, "Math" },
                    { 2, "Geography" },
                    { 3, "English" },
                    { 4, "Biology" }
                });

            migrationBuilder.InsertData(
                table: "SchoolClasses",
                columns: new[] { "SchoolClassId", "SchoolClassName" },
                values: new object[,]
                {
                    { 1, "1A" },
                    { 2, "2B" }
                });

            migrationBuilder.InsertData(
                table: "SchoolClassCourses",
                columns: new[] { "SchoolClassCourseId", "fkCourseId", "fkSchoolClassId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Age", "FirstName", "Gender", "LastName", "fkSchoolClassId", "fkStudentTeacherId" },
                values: new object[,]
                {
                    { 1, 12, "Adam", "M", "Jansson", 1, 1 },
                    { 2, 12, "Jenny", "F", "LindKvist", 1, 1 },
                    { 3, 12, "Marcus", "M", "Jonsson", 1, 1 },
                    { 4, 12, "Anna", "F", "Wiklund", 1, 1 },
                    { 5, 12, "Johannes", "M", "Öberg", 1, 1 },
                    { 6, 12, "Adam", "M", "Sundqvist", 1, 1 },
                    { 7, 12, "Linus", "M", "Lundgren", 1, 1 },
                    { 8, 12, "Hamphus", "M", "Stenberg", 1, 1 },
                    { 9, 12, "Linda", "F", "Lundgren", 1, 1 },
                    { 10, 12, "Julia", "F", "Nygren", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Age", "FirstName", "Gender", "LastName", "fkCourseId" },
                values: new object[,]
                {
                    { 1, 52, "Bengt", "M", "Svensson", 1 },
                    { 2, 42, "Sara", "F", "Häggkvist", 2 },
                    { 3, 38, "Linus", "M", "Skalare", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClassCourses_fkCourseId",
                table: "SchoolClassCourses",
                column: "fkCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClassCourses_fkSchoolClassId",
                table: "SchoolClassCourses",
                column: "fkSchoolClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_fkSchoolClassId",
                table: "Students",
                column: "fkSchoolClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_fkCourseId",
                table: "Teachers",
                column: "fkCourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolClassCourses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "SchoolClasses");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
