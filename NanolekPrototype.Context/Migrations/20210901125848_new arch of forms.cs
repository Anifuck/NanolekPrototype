using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class newarchofforms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckingProcedures_FormCheckingCheckweighingSettings_FormCheckingCheckweighingSettingId",
                table: "CheckingProcedures");

            migrationBuilder.DropForeignKey(
                name: "FK_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingControls_FormControlOfPrimaryPackagings_FormControlOfPrimaryPackagingId",
                table: "PackagingControls");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterials_FormReceptionAndMovementOfPackingMaterialId",
                table: "ReceptionOfMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_SampleSelections_FormSamplingFinishedProducts_FormSamplingFinishedProductId",
                table: "SampleSelections");

            migrationBuilder.DropForeignKey(
                name: "FK_SettingUpTechnologicalEquipments_FormSettingUpTechnologicalEquipments_FormSettingUpTechnologicalEquipmentId",
                table: "SettingUpTechnologicalEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_TabeProcedures_FormSamplingFinishedProducts_FormSamplingFinishedProductId",
                table: "TabeProcedures");

            migrationBuilder.DropForeignKey(
                name: "FK_TabeProcedures_Procedures_ProcedureId",
                table: "TabeProcedures");

            migrationBuilder.DropForeignKey(
                name: "FK_VerificationActions_FormCheckingRejectionOfDefectiveTablets_FormCheckingRejectionOfDefectiveTabletId",
                table: "VerificationActions");

            migrationBuilder.DropTable(
                name: "FormCheckingCheckweighingSettings");

            migrationBuilder.DropTable(
                name: "FormCheckingRejectionOfDefectiveTablets");

            migrationBuilder.DropTable(
                name: "FormControlOfPrimaryPackagings");

            migrationBuilder.DropTable(
                name: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropTable(
                name: "FormReceptionAndMovementOfBulkProducts");

            migrationBuilder.DropTable(
                name: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropTable(
                name: "FormSamplingFinishedProducts");

            migrationBuilder.DropTable(
                name: "FormSettingUpTechnologicalEquipments");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_TabeProcedures_ProcedureId",
                table: "TabeProcedures");

            migrationBuilder.DropColumn(
                name: "ProcedureId",
                table: "TabeProcedures");

            migrationBuilder.RenameColumn(
                name: "FormRequisitesJson",
                table: "PackagingProtocolForms",
                newName: "Specification");

            migrationBuilder.AddColumn<int>(
                name: "Procedure",
                table: "TabeProcedures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CalcedByUserDate",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CalcedByUserId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckedByUserDate",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CheckedByUserId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckedPUByUserDate",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CheckedPUByUserId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckingDate",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DefectFirstPackageUnits",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntredIntoGPPackages",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntredIntoGPUnits",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExitAccordingToTheRegulations",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpenseFor1000Packs",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishDateOfPacking",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocolId",
                table: "PackagingProtocolForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FormCheckingCheckweighingSetting_PackagingProtocolId",
                table: "PackagingProtocolForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FormCheckingRejectionOfDefectiveTablet_PackagingProtocolId",
                table: "PackagingProtocolForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FormControlOfPrimaryPackaging_PackagingProtocolId",
                table: "PackagingProtocolForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FormMaterialBalanceOfGPByLot_CalcedByUserDate",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormMaterialBalanceOfGPByLot_CalcedByUserId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FormMaterialBalanceOfGPByLot_CheckedByUserDate",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormMaterialBalanceOfGPByLot_CheckedByUserId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FormMaterialBalanceOfGPByLot_Date",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormMaterialBalanceOfGPByLot_Observations",
                table: "PackagingProtocolForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FormMaterialBalanceOfGPByLot_PackagingProtocolId",
                table: "PackagingProtocolForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormMaterialBalanceOfGPByLot_ShiftMasterId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormMaterialBalanceOfGPByLot_TaskMasterId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FormReceptionAndMovementOfBulkProduct_CalcedByUserDate",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormReceptionAndMovementOfBulkProduct_CalcedByUserId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FormReceptionAndMovementOfBulkProduct_CheckedByUserDate",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormReceptionAndMovementOfBulkProduct_CheckedByUserId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FormReceptionAndMovementOfBulkProduct_Date",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormReceptionAndMovementOfBulkProduct_InternalCodeOfMaterial",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FormReceptionAndMovementOfBulkProduct_PackagingProtocolId",
                table: "PackagingProtocolForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormReceptionAndMovementOfBulkProduct_ShiftMasterId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormReceptionAndMovementOfBulkProduct_Specification",
                table: "PackagingProtocolForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FormReceptionAndMovementOfPackingMaterial_Date",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormReceptionAndMovementOfPackingMaterial_Observations",
                table: "PackagingProtocolForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FormReceptionAndMovementOfPackingMaterial_PackagingProtocolId",
                table: "PackagingProtocolForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormReceptionAndMovementOfPackingMaterial_ShiftMasterId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FormSamplingFinishedProduct_PackagingProtocolId",
                table: "PackagingProtocolForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormStatus",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GarbageSecondPackageUnits",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GarbageUnits",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GetPRP",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InternalCodeOfMaterial",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompliant",
                table: "PackagingProtocolForms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrespondToControlIndicators",
                table: "PackagingProtocolForms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrespondToShelfLife",
                table: "PackagingProtocolForms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrespondenceEligibilityCriteria",
                table: "PackagingProtocolForms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrespondsToConsumptionRate",
                table: "PackagingProtocolForms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSentToStorage",
                table: "PackagingProtocolForms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsStoredInProduction",
                table: "PackagingProtocolForms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NotificationDate",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NotificationNUmber",
                table: "PackagingProtocolForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observations",
                table: "PackagingProtocolForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PackagesCount",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartSAP",
                table: "PackagingProtocolForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProtocolNumber",
                table: "PackagingProtocolForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reconciliation",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RemainingMaterial",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SampleSelectionUnits",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftMasterDate",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShiftMasterId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpentOnBatch",
                table: "PackagingProtocolForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateOfPacking",
                table: "PackagingProtocolForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaskMasterId",
                table: "PackagingProtocolForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_CalcedByUserId",
                table: "PackagingProtocolForms",
                column: "CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_CheckedByUserId",
                table: "PackagingProtocolForms",
                column: "CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_CheckedPUByUserId",
                table: "PackagingProtocolForms",
                column: "CheckedPUByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormCheckingCheckweighingSetting_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormCheckingCheckweighingSetting_PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormCheckingRejectionOfDefectiveTablet_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormCheckingRejectionOfDefectiveTablet_PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormControlOfPrimaryPackaging_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormControlOfPrimaryPackaging_PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_CalcedByUserId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_CheckedByUserId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_TaskMasterId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_TaskMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_CalcedByUserId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_CheckedByUserId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfPackingMaterial_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfPackingMaterial_PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfPackingMaterial_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfPackingMaterial_ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormSamplingFinishedProduct_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormSamplingFinishedProduct_PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_TaskMasterId",
                table: "PackagingProtocolForms",
                column: "TaskMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckingProcedures_PackagingProtocolForms_FormCheckingCheckweighingSettingId",
                table: "CheckingProcedures",
                column: "FormCheckingCheckweighingSettingId",
                principalTable: "PackagingProtocolForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovementOfBulkProducts_PackagingProtocolForms_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts",
                column: "FormReceptionAndMovementOfBulkProductId",
                principalTable: "PackagingProtocolForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingControls_PackagingProtocolForms_FormControlOfPrimaryPackagingId",
                table: "PackagingControls",
                column: "FormControlOfPrimaryPackagingId",
                principalTable: "PackagingProtocolForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_CalcedByUserId",
                table: "PackagingProtocolForms",
                column: "CalcedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_CheckedByUserId",
                table: "PackagingProtocolForms",
                column: "CheckedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_CheckedPUByUserId",
                table: "PackagingProtocolForms",
                column: "CheckedPUByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_CalcedByUserId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_CalcedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_CheckedByUserId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_CheckedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_TaskMasterId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_TaskMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfBulkProduct_CalcedByUserId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_CalcedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfBulkProduct_CheckedByUserId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_CheckedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfBulkProduct_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfPackingMaterial_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfPackingMaterial_ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_TaskMasterId",
                table: "PackagingProtocolForms",
                column: "TaskMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormCheckingCheckweighingSetting_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormCheckingCheckweighingSetting_PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormCheckingRejectionOfDefectiveTablet_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormCheckingRejectionOfDefectiveTablet_PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormControlOfPrimaryPackaging_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormControlOfPrimaryPackaging_PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormMaterialBalanceOfGPByLot_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormReceptionAndMovementOfBulkProduct_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormReceptionAndMovementOfPackingMaterial_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfPackingMaterial_PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormSamplingFinishedProduct_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "FormSamplingFinishedProduct_PackagingProtocolId",
                principalTable: "PackagingProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceptionOfMaterials_PackagingProtocolForms_FormReceptionAndMovementOfPackingMaterialId",
                table: "ReceptionOfMaterials",
                column: "FormReceptionAndMovementOfPackingMaterialId",
                principalTable: "PackagingProtocolForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SampleSelections_PackagingProtocolForms_FormSamplingFinishedProductId",
                table: "SampleSelections",
                column: "FormSamplingFinishedProductId",
                principalTable: "PackagingProtocolForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SettingUpTechnologicalEquipments_PackagingProtocolForms_FormSettingUpTechnologicalEquipmentId",
                table: "SettingUpTechnologicalEquipments",
                column: "FormSettingUpTechnologicalEquipmentId",
                principalTable: "PackagingProtocolForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TabeProcedures_PackagingProtocolForms_FormSamplingFinishedProductId",
                table: "TabeProcedures",
                column: "FormSamplingFinishedProductId",
                principalTable: "PackagingProtocolForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VerificationActions_PackagingProtocolForms_FormCheckingRejectionOfDefectiveTabletId",
                table: "VerificationActions",
                column: "FormCheckingRejectionOfDefectiveTabletId",
                principalTable: "PackagingProtocolForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckingProcedures_PackagingProtocolForms_FormCheckingCheckweighingSettingId",
                table: "CheckingProcedures");

            migrationBuilder.DropForeignKey(
                name: "FK_MovementOfBulkProducts_PackagingProtocolForms_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingControls_PackagingProtocolForms_FormControlOfPrimaryPackagingId",
                table: "PackagingControls");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_CalcedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_CheckedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_CheckedPUByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_CalcedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_CheckedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_TaskMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfBulkProduct_CalcedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfBulkProduct_CheckedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfBulkProduct_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfPackingMaterial_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_AspNetUsers_TaskMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormCheckingCheckweighingSetting_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormCheckingRejectionOfDefectiveTablet_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormControlOfPrimaryPackaging_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormMaterialBalanceOfGPByLot_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormReceptionAndMovementOfBulkProduct_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormReceptionAndMovementOfPackingMaterial_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocolForms_PackagingProtocols_FormSamplingFinishedProduct_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceptionOfMaterials_PackagingProtocolForms_FormReceptionAndMovementOfPackingMaterialId",
                table: "ReceptionOfMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_SampleSelections_PackagingProtocolForms_FormSamplingFinishedProductId",
                table: "SampleSelections");

            migrationBuilder.DropForeignKey(
                name: "FK_SettingUpTechnologicalEquipments_PackagingProtocolForms_FormSettingUpTechnologicalEquipmentId",
                table: "SettingUpTechnologicalEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_TabeProcedures_PackagingProtocolForms_FormSamplingFinishedProductId",
                table: "TabeProcedures");

            migrationBuilder.DropForeignKey(
                name: "FK_VerificationActions_PackagingProtocolForms_FormCheckingRejectionOfDefectiveTabletId",
                table: "VerificationActions");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_CalcedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_CheckedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_CheckedPUByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormCheckingCheckweighingSetting_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormCheckingRejectionOfDefectiveTablet_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormControlOfPrimaryPackaging_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_CalcedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_CheckedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_TaskMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_CalcedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_CheckedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfPackingMaterial_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfPackingMaterial_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_FormSamplingFinishedProduct_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropIndex(
                name: "IX_PackagingProtocolForms_TaskMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "Procedure",
                table: "TabeProcedures");

            migrationBuilder.DropColumn(
                name: "CalcedByUserDate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "CalcedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "CheckedByUserDate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "CheckedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "CheckedPUByUserDate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "CheckedPUByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "CheckingDate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "DefectFirstPackageUnits",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "EntredIntoGPPackages",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "EntredIntoGPUnits",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "ExitAccordingToTheRegulations",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "ExpenseFor1000Packs",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FinishDateOfPacking",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormCheckingCheckweighingSetting_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormCheckingRejectionOfDefectiveTablet_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormControlOfPrimaryPackaging_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormMaterialBalanceOfGPByLot_CalcedByUserDate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormMaterialBalanceOfGPByLot_CalcedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormMaterialBalanceOfGPByLot_CheckedByUserDate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormMaterialBalanceOfGPByLot_CheckedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormMaterialBalanceOfGPByLot_Date",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormMaterialBalanceOfGPByLot_Observations",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormMaterialBalanceOfGPByLot_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormMaterialBalanceOfGPByLot_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormMaterialBalanceOfGPByLot_TaskMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfBulkProduct_CalcedByUserDate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfBulkProduct_CalcedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfBulkProduct_CheckedByUserDate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfBulkProduct_CheckedByUserId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfBulkProduct_Date",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfBulkProduct_InternalCodeOfMaterial",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfBulkProduct_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfBulkProduct_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfBulkProduct_Specification",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfPackingMaterial_Date",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfPackingMaterial_Observations",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfPackingMaterial_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormReceptionAndMovementOfPackingMaterial_ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormSamplingFinishedProduct_PackagingProtocolId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "FormStatus",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "GarbageSecondPackageUnits",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "GarbageUnits",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "GetPRP",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "InternalCodeOfMaterial",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "IsCompliant",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "IsCorrespondToControlIndicators",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "IsCorrespondToShelfLife",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "IsCorrespondenceEligibilityCriteria",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "IsCorrespondsToConsumptionRate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "IsSentToStorage",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "IsStoredInProduction",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "NotificationDate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "NotificationNUmber",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "Observations",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "PackagesCount",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "PartSAP",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "ProtocolNumber",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "Reconciliation",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "RemainingMaterial",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "SampleSelectionUnits",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "ShiftMasterDate",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "ShiftMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "SpentOnBatch",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "StartDateOfPacking",
                table: "PackagingProtocolForms");

            migrationBuilder.DropColumn(
                name: "TaskMasterId",
                table: "PackagingProtocolForms");

            migrationBuilder.RenameColumn(
                name: "Specification",
                table: "PackagingProtocolForms",
                newName: "FormRequisitesJson");

            migrationBuilder.AddColumn<int>(
                name: "ProcedureId",
                table: "TabeProcedures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FormCheckingCheckweighingSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormCheckingCheckweighingSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormCheckingCheckweighingSettings_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormCheckingRejectionOfDefectiveTablets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormCheckingRejectionOfDefectiveTablets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormCheckingRejectionOfDefectiveTablets_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormControlOfPrimaryPackagings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormControlOfPrimaryPackagings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormControlOfPrimaryPackagings_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormMaterialBalanceOfGpByLots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalcedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedPUByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedPUByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitAccordingToTheRegulations = table.Column<int>(type: "int", nullable: false),
                    FinishDateOfPacking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsCompliant = table.Column<bool>(type: "bit", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackagesCount = table.Column<int>(type: "int", nullable: false),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    ShiftMasterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StartDateOfPacking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormMaterialBalanceOfGpByLots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CalcedByUserId",
                        column: x => x.CalcedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedByUserId",
                        column: x => x.CheckedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedPUByUserId",
                        column: x => x.CheckedPUByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_TaskMasterId",
                        column: x => x.TaskMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormReceptionAndMovementOfBulkProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalcedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DefectFirstPackageUnits = table.Column<int>(type: "int", nullable: false),
                    EntredIntoGPPackages = table.Column<int>(type: "int", nullable: false),
                    EntredIntoGPUnits = table.Column<int>(type: "int", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    GarbageSecondPackageUnits = table.Column<int>(type: "int", nullable: false),
                    GarbageUnits = table.Column<int>(type: "int", nullable: false),
                    GetPRP = table.Column<int>(type: "int", nullable: false),
                    InternalCodeOfMaterial = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsCorrespondToControlIndicators = table.Column<bool>(type: "bit", nullable: false),
                    IsCorrespondToShelfLife = table.Column<bool>(type: "bit", nullable: false),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    PartSAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SampleSelectionUnits = table.Column<int>(type: "int", nullable: false),
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormReceptionAndMovementOfBulkProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_CalcedByUserId",
                        column: x => x.CalcedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_CheckedByUserId",
                        column: x => x.CheckedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormReceptionAndMovementOfPackingMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalcedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpenseFor1000Packs = table.Column<int>(type: "int", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    InternalCodeOfMaterial = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsCorrespondenceEligibilityCriteria = table.Column<bool>(type: "bit", nullable: false),
                    IsCorrespondsToConsumptionRate = table.Column<bool>(type: "bit", nullable: false),
                    IsSentToStorage = table.Column<bool>(type: "bit", nullable: false),
                    IsStoredInProduction = table.Column<bool>(type: "bit", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    Reconciliation = table.Column<int>(type: "int", nullable: false),
                    RemainingMaterial = table.Column<int>(type: "int", nullable: false),
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpentOnBatch = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormReceptionAndMovementOfPackingMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CalcedByUserId",
                        column: x => x.CalcedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CheckedByUserId",
                        column: x => x.CheckedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfPackingMaterials_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormSamplingFinishedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotificationNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    ProtocolNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSamplingFinishedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormSamplingFinishedProducts_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormSamplingFinishedProducts_AspNetUsers_TaskMasterId",
                        column: x => x.TaskMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormSamplingFinishedProducts_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormSettingUpTechnologicalEquipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSettingUpTechnologicalEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormSettingUpTechnologicalEquipments_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabeProcedures_ProcedureId",
                table: "TabeProcedures",
                column: "ProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCheckingCheckweighingSettings_PackagingProtocolId",
                table: "FormCheckingCheckweighingSettings",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCheckingRejectionOfDefectiveTablets_PackagingProtocolId",
                table: "FormCheckingRejectionOfDefectiveTablets",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormControlOfPrimaryPackagings_PackagingProtocolId",
                table: "FormControlOfPrimaryPackagings",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_CalcedByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_CheckedByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_CheckedPUByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CheckedPUByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_PackagingProtocolId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_ShiftMasterId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_TaskMasterId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "TaskMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfBulkProducts_CalcedByUserId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfBulkProducts_CheckedByUserId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfBulkProducts_PackagingProtocolId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfBulkProducts_ShiftMasterId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfPackingMaterials_CalcedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfPackingMaterials_CheckedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfPackingMaterials_PackagingProtocolId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfPackingMaterials_ShiftMasterId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSamplingFinishedProducts_PackagingProtocolId",
                table: "FormSamplingFinishedProducts",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSamplingFinishedProducts_ShiftMasterId",
                table: "FormSamplingFinishedProducts",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSamplingFinishedProducts_TaskMasterId",
                table: "FormSamplingFinishedProducts",
                column: "TaskMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSettingUpTechnologicalEquipments_PackagingProtocolId",
                table: "FormSettingUpTechnologicalEquipments",
                column: "PackagingProtocolId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckingProcedures_FormCheckingCheckweighingSettings_FormCheckingCheckweighingSettingId",
                table: "CheckingProcedures",
                column: "FormCheckingCheckweighingSettingId",
                principalTable: "FormCheckingCheckweighingSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts",
                column: "FormReceptionAndMovementOfBulkProductId",
                principalTable: "FormReceptionAndMovementOfBulkProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingControls_FormControlOfPrimaryPackagings_FormControlOfPrimaryPackagingId",
                table: "PackagingControls",
                column: "FormControlOfPrimaryPackagingId",
                principalTable: "FormControlOfPrimaryPackagings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterials_FormReceptionAndMovementOfPackingMaterialId",
                table: "ReceptionOfMaterials",
                column: "FormReceptionAndMovementOfPackingMaterialId",
                principalTable: "FormReceptionAndMovementOfPackingMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SampleSelections_FormSamplingFinishedProducts_FormSamplingFinishedProductId",
                table: "SampleSelections",
                column: "FormSamplingFinishedProductId",
                principalTable: "FormSamplingFinishedProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SettingUpTechnologicalEquipments_FormSettingUpTechnologicalEquipments_FormSettingUpTechnologicalEquipmentId",
                table: "SettingUpTechnologicalEquipments",
                column: "FormSettingUpTechnologicalEquipmentId",
                principalTable: "FormSettingUpTechnologicalEquipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TabeProcedures_FormSamplingFinishedProducts_FormSamplingFinishedProductId",
                table: "TabeProcedures",
                column: "FormSamplingFinishedProductId",
                principalTable: "FormSamplingFinishedProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TabeProcedures_Procedures_ProcedureId",
                table: "TabeProcedures",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VerificationActions_FormCheckingRejectionOfDefectiveTablets_FormCheckingRejectionOfDefectiveTabletId",
                table: "VerificationActions",
                column: "FormCheckingRejectionOfDefectiveTabletId",
                principalTable: "FormCheckingRejectionOfDefectiveTablets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
