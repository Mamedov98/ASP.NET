using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityHW.Migrations
{
    /// <inheritdoc />
    public partial class ForecastHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForecastHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temp = table.Column<double>(type: "float", nullable: false),
                    Humidity = table.Column<int>(type: "int", nullable: false),
                    FeelsLike = table.Column<double>(type: "float", nullable: false),
                    WindSpeed = table.Column<double>(type: "float", nullable: false),
                    Pressure = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForecastHistories", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForecastHistories");
        }
    }
}
