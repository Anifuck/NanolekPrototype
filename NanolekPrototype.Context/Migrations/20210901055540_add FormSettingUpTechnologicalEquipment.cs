using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class addFormSettingUpTechnologicalEquipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResReceptionOfMaterials_AspNetUsers_ShiftMasterId",
                table: "ResReceptionOfMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_ResReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterials_FormReceptionAndMovementOfPackingMaterialId",
                table: "ResReceptionOfMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResReceptionOfMaterials",
                table: "ResReceptionOfMaterials");

            migrationBuilder.RenameTable(
                name: "ResReceptionOfMaterials",
                newName: "ReceptionOfMaterials");

            migrationBuilder.RenameIndex(
                name: "IX_ResReceptionOfMaterials_ShiftMasterId",
                table: "ReceptionOfMaterials",
                newName: "IX_ReceptionOfMaterials_ShiftMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_ResReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterialId",
                table: "ReceptionOfMaterials",
                newName: "IX_ReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceptionOfMaterials",
                table: "ReceptionOfMaterials",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FormSettingUpTechnologicalEquipments",
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
                    table.PrimaryKey("PK_FormSettingUpTechnologicalEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormSettingUpTechnologicalEquipments_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SettingUpTechnologicalEquipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormSettingUpTechnologicalEquipmentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ServiceTechnicianId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingUpTechnologicalEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SettingUpTechnologicalEquipments_AspNetUsers_ServiceTechnicianId",
                        column: x => x.ServiceTechnicianId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SettingUpTechnologicalEquipments_FormSettingUpTechnologicalEquipments_FormSettingUpTechnologicalEquipmentId",
                        column: x => x.FormSettingUpTechnologicalEquipmentId,
                        principalTable: "FormSettingUpTechnologicalEquipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormSettingUpTechnologicalEquipments_PackagingProtocolId",
                table: "FormSettingUpTechnologicalEquipments",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingUpTechnologicalEquipments_FormSettingUpTechnologicalEquipmentId",
                table: "SettingUpTechnologicalEquipments",
                column: "FormSettingUpTechnologicalEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingUpTechnologicalEquipments_ServiceTechnicianId",
                table: "SettingUpTechnologicalEquipments",
                column: "ServiceTechnicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceptionOfMaterials_AspNetUsers_ShiftMasterId",
                table: "ReceptionOfMaterials",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterials_FormReceptionAndMovementOfPackingMaterialId",
                table: "ReceptionOfMaterials",
                column: "FormReceptionAndMovementOfPackingMaterialId",
                principalTable: "FormReceptionAndMovementOfPackingMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceptionOfMaterials_AspNetUsers_ShiftMasterId",
                table: "ReceptionOfMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterials_FormReceptionAndMovementOfPackingMaterialId",
                table: "ReceptionOfMaterials");

            migrationBuilder.DropTable(
                name: "SettingUpTechnologicalEquipments");

            migrationBuilder.DropTable(
                name: "FormSettingUpTechnologicalEquipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceptionOfMaterials",
                table: "ReceptionOfMaterials");

            migrationBuilder.RenameTable(
                name: "ReceptionOfMaterials",
                newName: "ResReceptionOfMaterials");

            migrationBuilder.RenameIndex(
                name: "IX_ReceptionOfMaterials_ShiftMasterId",
                table: "ResReceptionOfMaterials",
                newName: "IX_ResReceptionOfMaterials_ShiftMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_ReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterialId",
                table: "ResReceptionOfMaterials",
                newName: "IX_ResReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResReceptionOfMaterials",
                table: "ResReceptionOfMaterials",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResReceptionOfMaterials_AspNetUsers_ShiftMasterId",
                table: "ResReceptionOfMaterials",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterials_FormReceptionAndMovementOfPackingMaterialId",
                table: "ResReceptionOfMaterials",
                column: "FormReceptionAndMovementOfPackingMaterialId",
                principalTable: "FormReceptionAndMovementOfPackingMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
