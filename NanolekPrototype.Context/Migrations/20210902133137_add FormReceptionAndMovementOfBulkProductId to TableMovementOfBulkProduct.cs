using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class addFormReceptionAndMovementOfBulkProductIdtoTableMovementOfBulkProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts");

            migrationBuilder.AlterColumn<int>(
                name: "FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts",
                column: "FormReceptionAndMovementOfBulkProductId",
                principalTable: "FormReceptionAndMovementOfBulkProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts");

            migrationBuilder.AlterColumn<int>(
                name: "FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts",
                column: "FormReceptionAndMovementOfBulkProductId",
                principalTable: "FormReceptionAndMovementOfBulkProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
