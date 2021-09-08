using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGivenId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.DropForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGotId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.AddColumn<DateTime>(
                name: "SellBy",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGivenId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "TaskGivenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGotId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "TaskGotId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGivenId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.DropForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGotId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.DropColumn(
                name: "SellBy",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.AddForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGivenId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "TaskGivenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGotId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "TaskGotId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
