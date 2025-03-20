using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PTPMQL.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Nhanvien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nhanvien",
                columns: table => new
                {
                    Ma_NV = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanvien", x => x.Ma_NV);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nhanvien");
        }
    }
}
