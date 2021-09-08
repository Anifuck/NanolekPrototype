using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class FormCheckingCheckweighingSetting2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckingProcedures_AspNetUsers_ExecutorId",
                table: "CheckingProcedures");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckingProcedures_AspNetUsers_ExecutorId",
                table: "CheckingProcedures",
                column: "ExecutorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckingProcedures_AspNetUsers_ExecutorId",
                table: "CheckingProcedures");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckingProcedures_AspNetUsers_ExecutorId",
                table: "CheckingProcedures",
                column: "ExecutorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
