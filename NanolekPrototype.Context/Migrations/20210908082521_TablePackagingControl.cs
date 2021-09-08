using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class TablePackagingControl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackagingControls_AspNetUsers_TaskMasterId",
                table: "PackagingControls");

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingControls_AspNetUsers_TaskMasterId",
                table: "PackagingControls",
                column: "TaskMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackagingControls_AspNetUsers_TaskMasterId",
                table: "PackagingControls");

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingControls_AspNetUsers_TaskMasterId",
                table: "PackagingControls",
                column: "TaskMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
