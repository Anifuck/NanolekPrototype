using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_ShiftMasterId",
                table: "FormReceptionAndMovementOfBulkProducts");

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_ShiftMasterId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_ShiftMasterId",
                table: "FormReceptionAndMovementOfBulkProducts");

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_ShiftMasterId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
