using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class newData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Air Conditioning" },
                    { 2, "Coffee Maker" },
                    { 3, "City View" },
                    { 4, "Jacuzzi Bathtub" },
                    { 5, "Fireplace" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "Name", "Phone" },
                values: new object[,]
                {
                    { 6, "1234 Chuckanut Way", "Bellingham", "360-123-4567" },
                    { 5, "123 Naito Way", "Portland", "503-123-4567" },
                    { 4, "8910 NW Market St.", "Ballard", "206-678-9123" },
                    { 2, "123 3rd Ave.", "Belltown", "206-123-4567" },
                    { 1, "123 3rd Ave.", "Belltown", "206-123-4567" },
                    { 3, "4567 NE 50th St.", "University District", "206-891-2345" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Layout", "Name" },
                values: new object[,]
                {
                    { 5, 1, "Puget" },
                    { 1, 2, "Cascade" },
                    { 2, 1, "Chinook" },
                    { 3, 2, "Rose" },
                    { 4, 3, "Rainier Suite" },
                    { 6, 2, "Salish" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
