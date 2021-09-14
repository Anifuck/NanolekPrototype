using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class AddprocedureDAtetoTableProceduresrenametoProcedureMarkDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcedureDate",
                table: "TabeProcedures");

            migrationBuilder.AddColumn<DateTime>(
                name: "ProcedureMarkDate",
                table: "TabeProcedures",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcedureMarkDate",
                table: "TabeProcedures");

            migrationBuilder.AddColumn<DateTime>(
                name: "ProcedureDate",
                table: "TabeProcedures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
