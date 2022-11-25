using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmProject.Presistence.Migrations
{
    public partial class tables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salons_Films_FilmId",
                table: "Salons");

            migrationBuilder.DropIndex(
                name: "IX_Salons_FilmId",
                table: "Salons");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Salons");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Salons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salons_FilmId",
                table: "Salons",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salons_Films_FilmId",
                table: "Salons",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id");
        }
    }
}
