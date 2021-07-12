using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SignLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WordVideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignLanguages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SignLanguages",
                columns: new[] { "Id", "Word", "WordVideoUrl" },
                values: new object[] { 1, "abandon", "http://dlmg.ro/wp-content/uploads/2017/08/abandon-2.mp4" });

            migrationBuilder.InsertData(
                table: "SignLanguages",
                columns: new[] { "Id", "Word", "WordVideoUrl" },
                values: new object[] { 2, "accepta", "http://dlmg.ro/wp-content/uploads/2017/06/accepta.mp4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SignLanguages");
        }
    }
}
