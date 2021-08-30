using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Migrations
{
    public partial class addPackagingProtocol2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_packagingProtocols_User_ResponsibleUserOOKId",
                table: "packagingProtocols");

            migrationBuilder.DropForeignKey(
                name: "FK_packagingProtocols_User_ResponsibleUserTLFId",
                table: "packagingProtocols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_packagingProtocols",
                table: "packagingProtocols");

            migrationBuilder.RenameTable(
                name: "packagingProtocols",
                newName: "PackagingProtocols");

            migrationBuilder.RenameIndex(
                name: "IX_packagingProtocols_ResponsibleUserTLFId",
                table: "PackagingProtocols",
                newName: "IX_PackagingProtocols_ResponsibleUserTLFId");

            migrationBuilder.RenameIndex(
                name: "IX_packagingProtocols_ResponsibleUserOOKId",
                table: "PackagingProtocols",
                newName: "IX_PackagingProtocols_ResponsibleUserOOKId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PackagingProtocols",
                table: "PackagingProtocols",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocols_User_ResponsibleUserOOKId",
                table: "PackagingProtocols",
                column: "ResponsibleUserOOKId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackagingProtocols_User_ResponsibleUserTLFId",
                table: "PackagingProtocols",
                column: "ResponsibleUserTLFId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocols_User_ResponsibleUserOOKId",
                table: "PackagingProtocols");

            migrationBuilder.DropForeignKey(
                name: "FK_PackagingProtocols_User_ResponsibleUserTLFId",
                table: "PackagingProtocols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PackagingProtocols",
                table: "PackagingProtocols");

            migrationBuilder.RenameTable(
                name: "PackagingProtocols",
                newName: "packagingProtocols");

            migrationBuilder.RenameIndex(
                name: "IX_PackagingProtocols_ResponsibleUserTLFId",
                table: "packagingProtocols",
                newName: "IX_packagingProtocols_ResponsibleUserTLFId");

            migrationBuilder.RenameIndex(
                name: "IX_PackagingProtocols_ResponsibleUserOOKId",
                table: "packagingProtocols",
                newName: "IX_packagingProtocols_ResponsibleUserOOKId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_packagingProtocols",
                table: "packagingProtocols",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_packagingProtocols_User_ResponsibleUserOOKId",
                table: "packagingProtocols",
                column: "ResponsibleUserOOKId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_packagingProtocols_User_ResponsibleUserTLFId",
                table: "packagingProtocols",
                column: "ResponsibleUserTLFId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
