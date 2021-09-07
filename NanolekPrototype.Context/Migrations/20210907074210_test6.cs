using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CalcedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CheckedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_ShiftMasterId",
                table: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceptionOfMaterials_AspNetUsers_ShiftMasterId",
                table: "ReceptionOfMaterials");

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CalcedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "CalcedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CheckedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "CheckedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_ShiftMasterId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceptionOfMaterials_AspNetUsers_ShiftMasterId",
                table: "ReceptionOfMaterials",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CalcedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CheckedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_ShiftMasterId",
                table: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceptionOfMaterials_AspNetUsers_ShiftMasterId",
                table: "ReceptionOfMaterials");

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CalcedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "CalcedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CheckedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "CheckedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_ShiftMasterId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceptionOfMaterials_AspNetUsers_ShiftMasterId",
                table: "ReceptionOfMaterials",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
