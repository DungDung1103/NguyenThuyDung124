using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThuyDung124.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableNTD0124 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTD0124",
                columns: table => new
                {
                    NTDId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NTDName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    NTDGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTD0124", x => x.NTDId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTD0124");
        }
    }
}
