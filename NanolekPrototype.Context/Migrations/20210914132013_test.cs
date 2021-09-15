using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocols_PackagingProtocolId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox");

            migrationBuilder.DropForeignKey(
                name: "FK_FormCheckingCheckweighingSettings_PackagingProtocols_PackagingProtocolId",
                table: "FormCheckingCheckweighingSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_FormCheckingRejectionOfDefectiveTablets_PackagingProtocols_PackagingProtocolId",
                table: "FormCheckingRejectionOfDefectiveTablets");

            migrationBuilder.DropForeignKey(
                name: "FK_FormControlOfPrimaryPackagings_PackagingProtocols_PackagingProtocolId",
                table: "FormControlOfPrimaryPackagings");

            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_PackagingProtocols_PackagingProtocolId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfBulkProducts_PackagingProtocols_PackagingProtocolId",
                table: "FormReceptionAndMovementOfBulkProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_PackagingProtocols_PackagingProtocolId",
                table: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_FormSamplingFinishedProducts_PackagingProtocols_PackagingProtocolId",
                table: "FormSamplingFinishedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_FormSettingUpTechnologicalEquipments_PackagingProtocols_PackagingProtocolId",
                table: "FormSettingUpTechnologicalEquipments");

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormSettingUpTechnologicalEquipments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormSamplingFinishedProducts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormReceptionAndMovementOfBulkProducts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormMaterialBalanceOfGpByLots",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormControlOfPrimaryPackagings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormCheckingRejectionOfDefectiveTablets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormCheckingCheckweighingSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocols_PackagingProtocolId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormCheckingCheckweighingSettings_PackagingProtocols_PackagingProtocolId",
                table: "FormCheckingCheckweighingSettings",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormCheckingRejectionOfDefectiveTablets_PackagingProtocols_PackagingProtocolId",
                table: "FormCheckingRejectionOfDefectiveTablets",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormControlOfPrimaryPackagings_PackagingProtocols_PackagingProtocolId",
                table: "FormControlOfPrimaryPackagings",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_PackagingProtocols_PackagingProtocolId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfBulkProducts_PackagingProtocols_PackagingProtocolId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_PackagingProtocols_PackagingProtocolId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormSamplingFinishedProducts_PackagingProtocols_PackagingProtocolId",
                table: "FormSamplingFinishedProducts",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormSettingUpTechnologicalEquipments_PackagingProtocols_PackagingProtocolId",
                table: "FormSettingUpTechnologicalEquipments",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocols_PackagingProtocolId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox");

            migrationBuilder.DropForeignKey(
                name: "FK_FormCheckingCheckweighingSettings_PackagingProtocols_PackagingProtocolId",
                table: "FormCheckingCheckweighingSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_FormCheckingRejectionOfDefectiveTablets_PackagingProtocols_PackagingProtocolId",
                table: "FormCheckingRejectionOfDefectiveTablets");

            migrationBuilder.DropForeignKey(
                name: "FK_FormControlOfPrimaryPackagings_PackagingProtocols_PackagingProtocolId",
                table: "FormControlOfPrimaryPackagings");

            migrationBuilder.DropForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_PackagingProtocols_PackagingProtocolId",
                table: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfBulkProducts_PackagingProtocols_PackagingProtocolId",
                table: "FormReceptionAndMovementOfBulkProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_PackagingProtocols_PackagingProtocolId",
                table: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_FormSamplingFinishedProducts_PackagingProtocols_PackagingProtocolId",
                table: "FormSamplingFinishedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_FormSettingUpTechnologicalEquipments_PackagingProtocols_PackagingProtocolId",
                table: "FormSettingUpTechnologicalEquipments");

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormSettingUpTechnologicalEquipments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormSamplingFinishedProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormReceptionAndMovementOfBulkProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormMaterialBalanceOfGpByLots",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormControlOfPrimaryPackagings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormCheckingRejectionOfDefectiveTablets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormCheckingCheckweighingSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PackagingProtocolId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocols_PackagingProtocolId",
                table: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormCheckingCheckweighingSettings_PackagingProtocols_PackagingProtocolId",
                table: "FormCheckingCheckweighingSettings",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormCheckingRejectionOfDefectiveTablets_PackagingProtocols_PackagingProtocolId",
                table: "FormCheckingRejectionOfDefectiveTablets",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormControlOfPrimaryPackagings_PackagingProtocols_PackagingProtocolId",
                table: "FormControlOfPrimaryPackagings",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormMaterialBalanceOfGpByLots_PackagingProtocols_PackagingProtocolId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfBulkProducts_PackagingProtocols_PackagingProtocolId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormReceptionAndMovementOfPackingMaterials_PackagingProtocols_PackagingProtocolId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormSamplingFinishedProducts_PackagingProtocols_PackagingProtocolId",
                table: "FormSamplingFinishedProducts",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormSettingUpTechnologicalEquipments_PackagingProtocols_PackagingProtocolId",
                table: "FormSettingUpTechnologicalEquipments",
                column: "PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
