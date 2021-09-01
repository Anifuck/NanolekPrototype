using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class addFormReceptionAndMovementOfPackingMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackagingProtocols",
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
                    PackagingProtocolStatus = table.Column<int>(type: "int", nullable: false),
                    CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingProtocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackagingProtocols_AspNetUsers_ResponsibleUserOOKId",
                        column: x => x.ResponsibleUserOOKId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocols_AspNetUsers_ResponsibleUserTLFId",
                        column: x => x.ResponsibleUserTLFId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormReceptionAndMovementOfBulkProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    InternalCodeOfMaterial = table.Column<int>(type: "int", nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalcedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GetPRP = table.Column<int>(type: "int", nullable: false),
                    PartSAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrespondToControlIndicators = table.Column<bool>(type: "bit", nullable: false),
                    IsCorrespondToShelfLife = table.Column<bool>(type: "bit", nullable: false),
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EntredIntoGPPackages = table.Column<int>(type: "int", nullable: false),
                    EntredIntoGPUnits = table.Column<int>(type: "int", nullable: false),
                    GarbageUnits = table.Column<int>(type: "int", nullable: false),
                    DefectFirstPackageUnits = table.Column<int>(type: "int", nullable: false),
                    SampleSelectionUnits = table.Column<int>(type: "int", nullable: false),
                    GarbageSecondPackageUnits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormReceptionAndMovementOfBulkProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_CalcedByUserId",
                        column: x => x.CalcedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_CheckedByUserId",
                        column: x => x.CheckedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormReceptionAndMovementOfPackingMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    InternalCodeOfMaterial = table.Column<int>(type: "int", nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalcedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpentOnBatch = table.Column<int>(type: "int", nullable: false),
                    RemainingMaterial = table.Column<int>(type: "int", nullable: false),
                    IsSentToStorage = table.Column<bool>(type: "bit", nullable: false),
                    IsStoredInProduction = table.Column<bool>(type: "bit", nullable: false),
                    ExpenseFor1000Packs = table.Column<int>(type: "int", nullable: false),
                    IsCorrespondsToConsumptionRate = table.Column<bool>(type: "bit", nullable: false),
                    Reconciliation = table.Column<int>(type: "int", nullable: false),
                    IsCorrespondenceEligibilityCriteria = table.Column<bool>(type: "bit", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormReceptionAndMovementOfPackingMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CalcedByUserId",
                        column: x => x.CalcedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_CheckedByUserId",
                        column: x => x.CheckedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfPackingMaterials_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfPackingMaterials_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovementOfBulkProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormReceptionAndMovementOfBulkProductId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GarbageKg = table.Column<int>(type: "int", nullable: false),
                    ExecutorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementOfBulkProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementOfBulkProducts_AspNetUsers_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                        column: x => x.FormReceptionAndMovementOfBulkProductId,
                        principalTable: "FormReceptionAndMovementOfBulkProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResReceptionOfMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormReceptionAndMovementOfPackingMaterialId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedFoil = table.Column<int>(type: "int", nullable: false),
                    RemainingProduction = table.Column<int>(type: "int", nullable: false),
                    SAPPart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnalyticalSheetNumberOKK = table.Column<int>(type: "int", nullable: false),
                    IsFoilMeetsControlParameters = table.Column<bool>(type: "bit", nullable: false),
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResReceptionOfMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResReceptionOfMaterials_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterials_FormReceptionAndMovementOfPackingMaterialId",
                        column: x => x.FormReceptionAndMovementOfPackingMaterialId,
                        principalTable: "FormReceptionAndMovementOfPackingMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfBulkProducts_CalcedByUserId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfBulkProducts_CheckedByUserId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfBulkProducts_PackagingProtocolId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfBulkProducts_ShiftMasterId",
                table: "FormReceptionAndMovementOfBulkProducts",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfPackingMaterials_CalcedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfPackingMaterials_CheckedByUserId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfPackingMaterials_PackagingProtocolId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormReceptionAndMovementOfPackingMaterials_ShiftMasterId",
                table: "FormReceptionAndMovementOfPackingMaterials",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementOfBulkProducts_ExecutorId",
                table: "MovementOfBulkProducts",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts",
                column: "FormReceptionAndMovementOfBulkProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocols_ResponsibleUserOOKId",
                table: "PackagingProtocols",
                column: "ResponsibleUserOOKId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocols_ResponsibleUserTLFId",
                table: "PackagingProtocols",
                column: "ResponsibleUserTLFId");

            migrationBuilder.CreateIndex(
                name: "IX_ResReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterialId",
                table: "ResReceptionOfMaterials",
                column: "FormReceptionAndMovementOfPackingMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ResReceptionOfMaterials_ShiftMasterId",
                table: "ResReceptionOfMaterials",
                column: "ShiftMasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MovementOfBulkProducts");

            migrationBuilder.DropTable(
                name: "ResReceptionOfMaterials");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "FormReceptionAndMovementOfBulkProducts");

            migrationBuilder.DropTable(
                name: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropTable(
                name: "PackagingProtocols");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
