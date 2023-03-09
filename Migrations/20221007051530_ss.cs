using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOAssignment1.Migrations
{
    public partial class ss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    StudentProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.StudentProgramId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPA = table.Column<double>(type: "float", nullable: false),
                    GPAScale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Program_StudentProgramId",
                        column: x => x.StudentProgramId,
                        principalTable: "Program",
                        principalColumn: "StudentProgramId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Program",
                columns: new[] { "StudentProgramId", "Name" },
                values: new object[,]
                {
                    { "BI", "Busnessis" },
                    { "CA", "Carpinter" },
                    { "CO", "Cooking" },
                    { "CP", "ComputerPorgramming" },
                    { "CPI", "ComputerPorgramming" },
                    { "HO", "Hotel" },
                    { "NU", "Nursing" },
                    { "PB", "Plumber" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "GPA", "GPAScale", "LastName", "StudentProgramId", "dataOfBirth" },
                values: new object[] { 1, "Maria", 2.5, "good", "Oliveira", "CP", "17/08/1997" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "GPA", "GPAScale", "LastName", "StudentProgramId", "dataOfBirth" },
                values: new object[] { 2, "Jose", 4.5, "good", "Oliveira", "NU", "17/08/1997" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "GPA", "GPAScale", "LastName", "StudentProgramId", "dataOfBirth" },
                values: new object[] { 3, "Carlos", 3.5, "good", "Oliveira", "PB", "17/08/1997" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentProgramId",
                table: "Students",
                column: "StudentProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Program");
        }
    }
}
