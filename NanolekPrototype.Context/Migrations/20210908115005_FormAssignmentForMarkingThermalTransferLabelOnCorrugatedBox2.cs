using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGivenId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.DropForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGotId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.DropForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_PackagingProtocols_PackagingProtocolId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.RenameTable(
                name: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                newName: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox");

            migrationBuilder.RenameIndex(
                name: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_TaskGotId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                newName: "IX_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_TaskGotId");

            migrationBuilder.RenameIndex(
                name: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_TaskGivenId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                newName: "IX_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_TaskGivenId");

            migrationBuilder.RenameIndex(
                name: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_PackagingProtocolId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                newName: "IX_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_AspNetUsers_TaskGivenId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                column: "TaskGivenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_AspNetUsers_TaskGotId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                column: "TaskGotId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocols_PackagingProtocolId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_AspNetUsers_TaskGivenId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox");

            migrationBuilder.DropForeignKey(
                name: "FK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_AspNetUsers_TaskGotId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox");

            migrationBuilder.DropForeignKey(
                name: "FK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocols_PackagingProtocolId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox");

            migrationBuilder.RenameTable(
                name: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                newName: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.RenameIndex(
                name: "IX_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_TaskGotId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                newName: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_TaskGotId");

            migrationBuilder.RenameIndex(
                name: "IX_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_TaskGivenId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                newName: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_TaskGivenId");

            migrationBuilder.RenameIndex(
                name: "IX_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocolId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                newName: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_PackagingProtocolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_PackagingProtocols_PackagingProtocolId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
