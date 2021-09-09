using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class addFormMaterialBalanceOfGPByLot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CalcedByUserId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedByUserId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedPUByUserId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_ShiftMasterId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_TaskMasterId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CalcedByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CalcedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CheckedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedPUByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CheckedPUByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_ShiftMasterId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_TaskMasterId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "TaskMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CalcedByUserId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedByUserId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedPUByUserId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_ShiftMasterId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_TaskMasterId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CalcedByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CalcedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CheckedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedPUByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CheckedPUByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_ShiftMasterId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_TaskMasterId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "TaskMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
