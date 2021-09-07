using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class addTableVerificationAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VerificationActions_AspNetUsers_TaskMasterId",
                table: "VerificationActions");

            migrationBuilder.AddForeignKey(
                name: "FK_VerificationActions_AspNetUsers_TaskMasterId",
                table: "VerificationActions",
                column: "TaskMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VerificationActions_AspNetUsers_TaskMasterId",
                table: "VerificationActions");

            migrationBuilder.AddForeignKey(
                name: "FK_VerificationActions_AspNetUsers_TaskMasterId",
                table: "VerificationActions",
                column: "TaskMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
