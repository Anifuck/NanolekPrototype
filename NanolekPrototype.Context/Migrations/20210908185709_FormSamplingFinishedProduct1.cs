using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class FormSamplingFinishedProduct1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormSamplingFinishedProducts_AspNetUsers_ShiftMasterId",
                table: "FormSamplingFinishedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_FormSamplingFinishedProducts_AspNetUsers_TaskMasterId",
                table: "FormSamplingFinishedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SampleSelections_AspNetUsers_EmployeeOKKId",
                table: "SampleSelections");

            migrationBuilder.DropForeignKey(
                name: "FK_TabeProcedures_AspNetUsers_CheckerId",
                table: "TabeProcedures");

            migrationBuilder.DropForeignKey(
                name: "FK_TabeProcedures_AspNetUsers_ExecutorId",
                table: "TabeProcedures");

            migrationBuilder.AddForeignKey(
                name: "FK_FormSamplingFinishedProducts_AspNetUsers_ShiftMasterId",
                table: "FormSamplingFinishedProducts",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormSamplingFinishedProducts_AspNetUsers_TaskMasterId",
                table: "FormSamplingFinishedProducts",
                column: "TaskMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SampleSelections_AspNetUsers_EmployeeOKKId",
                table: "SampleSelections",
                column: "EmployeeOKKId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TabeProcedures_AspNetUsers_CheckerId",
                table: "TabeProcedures",
                column: "CheckerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TabeProcedures_AspNetUsers_ExecutorId",
                table: "TabeProcedures",
                column: "ExecutorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormSamplingFinishedProducts_AspNetUsers_ShiftMasterId",
                table: "FormSamplingFinishedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_FormSamplingFinishedProducts_AspNetUsers_TaskMasterId",
                table: "FormSamplingFinishedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SampleSelections_AspNetUsers_EmployeeOKKId",
                table: "SampleSelections");

            migrationBuilder.DropForeignKey(
                name: "FK_TabeProcedures_AspNetUsers_CheckerId",
                table: "TabeProcedures");

            migrationBuilder.DropForeignKey(
                name: "FK_TabeProcedures_AspNetUsers_ExecutorId",
                table: "TabeProcedures");

            migrationBuilder.AddForeignKey(
                name: "FK_FormSamplingFinishedProducts_AspNetUsers_ShiftMasterId",
                table: "FormSamplingFinishedProducts",
                column: "ShiftMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormSamplingFinishedProducts_AspNetUsers_TaskMasterId",
                table: "FormSamplingFinishedProducts",
                column: "TaskMasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SampleSelections_AspNetUsers_EmployeeOKKId",
                table: "SampleSelections",
                column: "EmployeeOKKId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TabeProcedures_AspNetUsers_CheckerId",
                table: "TabeProcedures",
                column: "CheckerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TabeProcedures_AspNetUsers_ExecutorId",
                table: "TabeProcedures",
                column: "ExecutorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
