using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class addFormSamplingFinishedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    GTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Series = table.Column<int>(type: "int", nullable: false),
                    DateOfManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PacksInCorrugatedBox = table.Column<int>(type: "int", nullable: false),
                    InternalCode = table.Column<int>(type: "int", nullable: false),
                    TaskGivenId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskGivenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskGotId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskGotDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForMarkingThermalTransferLabelOnCorrugatedBoxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGivenId",
                        column: x => x.TaskGivenId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGotId",
                        column: x => x.TaskGotId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormCheckingCheckweighingSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false)
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
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    CheckingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false)
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
                name: "FormSamplingFinishedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    NotificationNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProtocolNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "CheckingProcedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormCheckingCheckweighingSettingId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Procedure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    ReferenceWeightOfGPPack = table.Column<double>(type: "float", nullable: false),
                    ActualWeightOfGPPack = table.Column<double>(type: "float", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExecutorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckingProcedures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckingProcedures_AspNetUsers_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CheckingProcedures_FormCheckingCheckweighingSettings_FormCheckingCheckweighingSettingId",
                        column: x => x.FormCheckingCheckweighingSettingId,
                        principalTable: "FormCheckingCheckweighingSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VerificationActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormCheckingRejectionOfDefectiveTabletId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    TaskMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerificationActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerificationActions_AspNetUsers_TaskMasterId",
                        column: x => x.TaskMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VerificationActions_FormCheckingRejectionOfDefectiveTablets_FormCheckingRejectionOfDefectiveTabletId",
                        column: x => x.FormCheckingRejectionOfDefectiveTabletId,
                        principalTable: "FormCheckingRejectionOfDefectiveTablets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackagingControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormControlOfPrimaryPackagingId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFoilCorrespondenceToSpecification = table.Column<bool>(type: "bit", nullable: false),
                    IsAppereanceWithoutDefects = table.Column<bool>(type: "bit", nullable: false),
                    IsClarityMarkAndCorrugationPattern = table.Column<bool>(type: "bit", nullable: false),
                    IsMatchingVariableData = table.Column<bool>(type: "bit", nullable: false),
                    IsBulkProductWithoutVisibleDamage = table.Column<bool>(type: "bit", nullable: false),
                    IsCorrespondsCountOfTabletsInBlister = table.Column<bool>(type: "bit", nullable: false),
                    ActualTemperatureOfCellFormingMin = table.Column<int>(type: "int", nullable: false),
                    ActualTemperatureOfCellFormingMax = table.Column<int>(type: "int", nullable: false),
                    ActualTemperatureOfBlisterAdhesion = table.Column<int>(type: "int", nullable: false),
                    BlisteringSpeed = table.Column<int>(type: "int", nullable: false),
                    TaskMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackagingControls_AspNetUsers_TaskMasterId",
                        column: x => x.TaskMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingControls_FormControlOfPrimaryPackagings_FormControlOfPrimaryPackagingId",
                        column: x => x.FormControlOfPrimaryPackagingId,
                        principalTable: "FormControlOfPrimaryPackagings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SampleSelections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormSamplingFinishedProductId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountOfSampleSelection = table.Column<int>(type: "int", nullable: false),
                    EmployeeOKKId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleSelections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleSelections_AspNetUsers_EmployeeOKKId",
                        column: x => x.EmployeeOKKId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleSelections_FormSamplingFinishedProducts_FormSamplingFinishedProductId",
                        column: x => x.FormSamplingFinishedProductId,
                        principalTable: "FormSamplingFinishedProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabeProcedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormSamplingFinishedProductId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProcedureId = table.Column<int>(type: "int", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ExecutorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabeProcedures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabeProcedures_AspNetUsers_CheckerId",
                        column: x => x.CheckerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabeProcedures_AspNetUsers_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabeProcedures_FormSamplingFinishedProducts_FormSamplingFinishedProductId",
                        column: x => x.FormSamplingFinishedProductId,
                        principalTable: "FormSamplingFinishedProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabeProcedures_Procedures_ProcedureId",
                        column: x => x.ProcedureId,
                        principalTable: "Procedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckingProcedures_ExecutorId",
                table: "CheckingProcedures",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckingProcedures_FormCheckingCheckweighingSettingId",
                table: "CheckingProcedures",
                column: "FormCheckingCheckweighingSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_PackagingProtocolId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_TaskGivenId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "TaskGivenId");

            migrationBuilder.CreateIndex(
                name: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_TaskGotId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "TaskGotId");

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
                name: "IX_PackagingControls_FormControlOfPrimaryPackagingId",
                table: "PackagingControls",
                column: "FormControlOfPrimaryPackagingId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingControls_TaskMasterId",
                table: "PackagingControls",
                column: "TaskMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleSelections_EmployeeOKKId",
                table: "SampleSelections",
                column: "EmployeeOKKId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleSelections_FormSamplingFinishedProductId",
                table: "SampleSelections",
                column: "FormSamplingFinishedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TabeProcedures_CheckerId",
                table: "TabeProcedures",
                column: "CheckerId");

            migrationBuilder.CreateIndex(
                name: "IX_TabeProcedures_ExecutorId",
                table: "TabeProcedures",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TabeProcedures_FormSamplingFinishedProductId",
                table: "TabeProcedures",
                column: "FormSamplingFinishedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TabeProcedures_ProcedureId",
                table: "TabeProcedures",
                column: "ProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_VerificationActions_FormCheckingRejectionOfDefectiveTabletId",
                table: "VerificationActions",
                column: "FormCheckingRejectionOfDefectiveTabletId");

            migrationBuilder.CreateIndex(
                name: "IX_VerificationActions_TaskMasterId",
                table: "VerificationActions",
                column: "TaskMasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckingProcedures");

            migrationBuilder.DropTable(
                name: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.DropTable(
                name: "PackagingControls");

            migrationBuilder.DropTable(
                name: "SampleSelections");

            migrationBuilder.DropTable(
                name: "TabeProcedures");

            migrationBuilder.DropTable(
                name: "VerificationActions");

            migrationBuilder.DropTable(
                name: "FormCheckingCheckweighingSettings");

            migrationBuilder.DropTable(
                name: "FormControlOfPrimaryPackagings");

            migrationBuilder.DropTable(
                name: "FormSamplingFinishedProducts");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "FormCheckingRejectionOfDefectiveTablets");
        }
    }
}
