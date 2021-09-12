using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormStatus",
                table: "FormReceptionAndMovementOfPackingMaterials");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormStatus",
                table: "FormReceptionAndMovementOfPackingMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
