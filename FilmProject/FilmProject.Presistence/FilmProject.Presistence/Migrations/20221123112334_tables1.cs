using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmProject.Presistence.Migrations
{
    public partial class tables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salons_Films_FilmId",
                table: "Salons");

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "Salons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Salons_Films_FilmId",
                table: "Salons",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salons_Films_FilmId",
                table: "Salons");

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "Salons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Salons_Films_FilmId",
                table: "Salons",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
