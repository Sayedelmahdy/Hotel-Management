using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Manager.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__tmp_ms_x__3214EC070939E04D",
                table: "reservation");


            migrationBuilder.AddPrimaryKey(
                name: "PK__tmp_ms_x__3214EC070939E04D",
                table: "reservation",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_reservation",
                table: "reservation");


            migrationBuilder.AddPrimaryKey(
                name: "PK__tmp_ms_x__3214EC070939E04D",
                table: "reservation",
                column: "Id");
        }
    }
}
