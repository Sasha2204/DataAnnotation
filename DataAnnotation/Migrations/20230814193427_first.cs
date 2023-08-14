using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAnnotation.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCompany = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.IdCompany);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mobile",
                columns: table => new
                {
                    IdMobile = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    idCompany = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobile", x => x.IdMobile);
                    table.ForeignKey(
                        name: "FK_Mobile_Companies_idCompany",
                        column: x => x.idCompany,
                        principalTable: "Companies",
                        principalColumn: "IdCompany",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mobile_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Population" },
                values: new object[,]
                {
                    { 1, "UKR", 45 },
                    { 2, "USA", 300 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_CountryId",
                table: "Mobile",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_idCompany",
                table: "Mobile",
                column: "idCompany");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mobile");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
