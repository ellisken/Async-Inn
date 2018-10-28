using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class fixData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Address", "Name", "Phone" },
                values: new object[] { "123 Main St.", "Bellevue", "425-123-4567" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Address", "Name", "Phone" },
                values: new object[] { "123 3rd Ave.", "Belltown", "206-123-4567" });
        }
    }
}
