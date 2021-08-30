﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Migrations
{
    public partial class addPackagingProtocol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "packagingProtocols",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleUserOOKId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StorageConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShelfLife = table.Column<double>(type: "float", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SellBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PackageNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleUserTLFId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificationGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalCodeGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packagingProtocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_packagingProtocols_User_ResponsibleUserOOKId",
                        column: x => x.ResponsibleUserOOKId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_packagingProtocols_User_ResponsibleUserTLFId",
                        column: x => x.ResponsibleUserTLFId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_packagingProtocols_ResponsibleUserOOKId",
                table: "packagingProtocols",
                column: "ResponsibleUserOOKId");

            migrationBuilder.CreateIndex(
                name: "IX_packagingProtocols_ResponsibleUserTLFId",
                table: "packagingProtocols",
                column: "ResponsibleUserTLFId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "packagingProtocols");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
