using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class TableProductionPersonellrestruct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionPersonnels_AspNetUsers_FullNameId",
                table: "ProductionPersonnels");

            migrationBuilder.AlterColumn<int>(
                name: "FullNameId",
                table: "ProductionPersonnels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionPersonnels_AspNetUsers_FullNameId",
                table: "ProductionPersonnels",
                column: "FullNameId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionPersonnels_AspNetUsers_FullNameId",
                table: "ProductionPersonnels");

            migrationBuilder.AlterColumn<int>(
                name: "FullNameId",
                table: "ProductionPersonnels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionPersonnels_AspNetUsers_FullNameId",
                table: "ProductionPersonnels",
                column: "FullNameId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
