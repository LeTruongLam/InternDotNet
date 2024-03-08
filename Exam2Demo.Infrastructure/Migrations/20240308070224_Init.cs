using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam2Demo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResidentApartments_Apartments_ApartmentId",
                table: "ResidentApartments");

            migrationBuilder.DropForeignKey(
                name: "FK_ResidentApartments_Residents_ResidentId",
                table: "ResidentApartments");

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentApartments_Apartments_ApartmentId",
                table: "ResidentApartments",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentApartments_Residents_ResidentId",
                table: "ResidentApartments",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResidentApartments_Apartments_ApartmentId",
                table: "ResidentApartments");

            migrationBuilder.DropForeignKey(
                name: "FK_ResidentApartments_Residents_ResidentId",
                table: "ResidentApartments");

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentApartments_Apartments_ApartmentId",
                table: "ResidentApartments",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentApartments_Residents_ResidentId",
                table: "ResidentApartments",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "Id");
        }
    }
}
