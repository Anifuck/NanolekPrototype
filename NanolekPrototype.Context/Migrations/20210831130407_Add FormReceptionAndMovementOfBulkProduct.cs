using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class AddFormReceptionAndMovementOfBulkProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormReceptionAndMovementOfBulkProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId = table.Column<long>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    InternalCodeOfMaterial = table.Column<int>(nullable: false),
                    Specification = table.Column<string>(nullable: true),
                    CalcedByUserId = table.Column<string>(nullable: true),
                    CalcedByUserDate = table.Column<DateTime>(nullable: false),
                    CheckedByUserId = table.Column<string>(nullable: true),
                    CheckedByUserDate = table.Column<DateTime>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    GetPRP = table.Column<int>(nullable: false),
                    PartSAP = table.Column<string>(nullable: true),
                    IsCorrespondToControlIndicators = table.Column<bool>(nullable: false),
                    IsCorrespondToShelfLife = table.Column<bool>(nullable: false),
                    ShiftMasterId = table.Column<string>(nullable: true),
                    EntredIntoGPPackages = table.Column<int>(nullable: false),
                    EntredIntoGPUnits = table.Column<int>(nullable: false),
                    GarbageUnits = table.Column<int>(nullable: false),
                    DefectFirstPackageUnits = table.Column<int>(nullable: false),
                    SampleSelectionUnits = table.Column<int>(nullable: false),
                    GarbageSecondPackageUnits = table.Column<int>(nullable: false)
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
                        name: "FK_FormReceptionAndMovementOfBulkProducts_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovementOfBulkProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormReceptionAndMovementOfBulkProductId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    GarbageKg = table.Column<int>(nullable: false),
                    ExecutorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementOfBulkProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementOfBulkProducts_AspNetUsers_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                        column: x => x.FormReceptionAndMovementOfBulkProductId,
                        principalTable: "FormReceptionAndMovementOfBulkProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_MovementOfBulkProducts_ExecutorId",
                table: "MovementOfBulkProducts",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts",
                column: "FormReceptionAndMovementOfBulkProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovementOfBulkProducts");

            migrationBuilder.DropTable(
                name: "FormReceptionAndMovementOfBulkProducts");
        }
    }
}
