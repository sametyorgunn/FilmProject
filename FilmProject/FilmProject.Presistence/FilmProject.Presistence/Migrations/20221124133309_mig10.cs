using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmProject.Presistence.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Salons_SalonId",
                table: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Films_SalonId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "SalonId",
                table: "Films");

            migrationBuilder.CreateIndex(
                name: "IX_FilmSalonMapTables_FilmId",
                table: "FilmSalonMapTables",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmSalonMapTables_SalonId",
                table: "FilmSalonMapTables",
                column: "SalonId");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmSalonMapTables_Films_FilmId",
                table: "FilmSalonMapTables",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmSalonMapTables_Salons_SalonId",
                table: "FilmSalonMapTables",
                column: "SalonId",
                principalTable: "Salons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmSalonMapTables_Films_FilmId",
                table: "FilmSalonMapTables");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmSalonMapTables_Salons_SalonId",
                table: "FilmSalonMapTables");

            migrationBuilder.DropIndex(
                name: "IX_FilmSalonMapTables_FilmId",
                table: "FilmSalonMapTables");

            migrationBuilder.DropIndex(
                name: "IX_FilmSalonMapTables_SalonId",
                table: "FilmSalonMapTables");

            migrationBuilder.AddColumn<int>(
                name: "SalonId",
                table: "Films",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Films_SalonId",
                table: "Films",
                column: "SalonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Salons_SalonId",
                table: "Films",
                column: "SalonId",
                principalTable: "Salons",
                principalColumn: "Id");
        }
    }
}
