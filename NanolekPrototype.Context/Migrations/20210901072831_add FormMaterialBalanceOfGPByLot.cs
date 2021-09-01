using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class addFormMaterialBalanceOfGPByLot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormMaterialBalanceOfGpByLots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    StartDateOfPacking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishDateOfPacking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ShiftMasterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalcedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedPUByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedPUByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PackagesCount = table.Column<int>(type: "int", nullable: false),
                    ExitAccordingToTheRegulations = table.Column<int>(type: "int", nullable: false),
                    IsCompliant = table.Column<bool>(type: "bit", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormMaterialBalanceOfGpByLots");
        }
    }
}
