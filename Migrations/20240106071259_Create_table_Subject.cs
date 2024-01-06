using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoHuyHoang781.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Subject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectID = table.Column<string>(type: "TEXT", nullable: false),
                    SubjectName = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentID = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectID);
                    table.ForeignKey(
                        name: "FK_Subject_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_StudentID",
                table: "Subject",
                column: "StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
