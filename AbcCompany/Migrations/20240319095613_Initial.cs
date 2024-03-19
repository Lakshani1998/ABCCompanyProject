using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbcCompany.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResellerName = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", nullable: false),
                    FaxNumber = table.Column<int>(type: "int", nullable: false),
                    ContactPersonName = table.Column<string>(type: "varchar(50)", nullable: false),
                    ContactPersonPhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resellers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resellers");
        }
    }
}
