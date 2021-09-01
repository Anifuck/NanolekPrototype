using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class addtabstoPackagingProtocol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonnelAccessProtocols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId1 = table.Column<long>(type: "bigint", nullable: true),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProtocolNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProtocolDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelAccessProtocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonnelAccessProtocols_PackagingProtocols_PackagingProtocolId1",
                        column: x => x.PackagingProtocolId1,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductionPersonnels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId1 = table.Column<long>(type: "bigint", nullable: true),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FullNameId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Step = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionPersonnels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionPersonnels_AspNetUsers_FullNameId",
                        column: x => x.FullNameId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductionPersonnels_PackagingProtocols_PackagingProtocolId1",
                        column: x => x.PackagingProtocolId1,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelAccessProtocols_PackagingProtocolId1",
                table: "PersonnelAccessProtocols",
                column: "PackagingProtocolId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionPersonnels_FullNameId",
                table: "ProductionPersonnels",
                column: "FullNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionPersonnels_PackagingProtocolId1",
                table: "ProductionPersonnels",
                column: "PackagingProtocolId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonnelAccessProtocols");

            migrationBuilder.DropTable(
                name: "ProductionPersonnels");
        }
    }
}
