using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class form543 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SettingUpTechnologicalEquipments_AspNetUsers_ServiceTechnicianId",
                table: "SettingUpTechnologicalEquipments");

            migrationBuilder.AddForeignKey(
                name: "FK_SettingUpTechnologicalEquipments_AspNetUsers_ServiceTechnicianId",
                table: "SettingUpTechnologicalEquipments",
                column: "ServiceTechnicianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SettingUpTechnologicalEquipments_AspNetUsers_ServiceTechnicianId",
                table: "SettingUpTechnologicalEquipments");

            migrationBuilder.AddForeignKey(
                name: "FK_SettingUpTechnologicalEquipments_AspNetUsers_ServiceTechnicianId",
                table: "SettingUpTechnologicalEquipments",
                column: "ServiceTechnicianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
