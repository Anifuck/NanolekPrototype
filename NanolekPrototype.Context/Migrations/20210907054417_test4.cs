using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleUserOOKId = table.Column<int>(type: "int", nullable: false),
                    StorageConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShelfLife = table.Column<double>(type: "float", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SellBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PackageNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleUserTLFId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PackagingProtocols_AspNetUsers_ResponsibleUserTLFId",
                        column: x => x.ResponsibleUserTLFId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GTIN = table.Column<int>(type: "int", nullable: false),
                    Series = table.Column<int>(type: "int", nullable: false),
                    DateOfManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PacksInCorrugatedBox = table.Column<int>(type: "int", nullable: false),
                    InternalCode = table.Column<int>(type: "int", nullable: false),
                    TaskGivenId = table.Column<int>(type: "int", nullable: true),
                    TaskGivenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskGotId = table.Column<int>(type: "int", nullable: true),
                    TaskGotDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForMarkingThermalTransferLabelOnCorrugatedBoxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGivenId",
                        column: x => x.TaskGivenId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_AspNetUsers_TaskGotId",
                        column: x => x.TaskGotId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForMarkingThermalTransferLabelOnCorrugatedBoxes_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormCheckingCheckweighingSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormCheckingCheckweighingSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormCheckingCheckweighingSettings_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormCheckingRejectionOfDefectiveTablets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormCheckingRejectionOfDefectiveTablets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormCheckingRejectionOfDefectiveTablets_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormControlOfPrimaryPackagings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormControlOfPrimaryPackagings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormControlOfPrimaryPackagings_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormMaterialBalanceOfGpByLots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDateOfPacking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishDateOfPacking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftMasterId = table.Column<int>(type: "int", nullable: true),
                    ShiftMasterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalcedByUserId = table.Column<int>(type: "int", nullable: true),
                    CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedByUserId = table.Column<int>(type: "int", nullable: true),
                    CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedPUByUserId = table.Column<int>(type: "int", nullable: true),
                    CheckedPUByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PackagesCount = table.Column<int>(type: "int", nullable: false),
                    ExitAccordingToTheRegulations = table.Column<int>(type: "int", nullable: false),
                    IsCompliant = table.Column<bool>(type: "bit", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskMasterId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormMaterialBalanceOfGpByLots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CalcedByUserId",
                        column: x => x.CalcedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedByUserId",
                        column: x => x.CheckedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_CheckedPUByUserId",
                        column: x => x.CheckedPUByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_AspNetUsers_TaskMasterId",
                        column: x => x.TaskMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMaterialBalanceOfGpByLots_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormReceptionAndMovementOfBulkProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternalCodeOfMaterial = table.Column<int>(type: "int", nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalcedByUserId = table.Column<int>(type: "int", nullable: true),
                    CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedByUserId = table.Column<int>(type: "int", nullable: true),
                    CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GetPRP = table.Column<int>(type: "int", nullable: false),
                    PartSAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrespondToControlIndicators = table.Column<bool>(type: "bit", nullable: false),
                    IsCorrespondToShelfLife = table.Column<bool>(type: "bit", nullable: false),
                    ShiftMasterId = table.Column<int>(type: "int", nullable: true),
                    EntredIntoGPPackages = table.Column<int>(type: "int", nullable: false),
                    EntredIntoGPUnits = table.Column<int>(type: "int", nullable: false),
                    GarbageUnits = table.Column<int>(type: "int", nullable: false),
                    DefectFirstPackageUnits = table.Column<int>(type: "int", nullable: false),
                    SampleSelectionUnits = table.Column<int>(type: "int", nullable: false),
                    GarbageSecondPackageUnits = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormReceptionAndMovementOfBulkProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_CalcedByUserId",
                        column: x => x.CalcedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormReceptionAndMovementOfBulkProducts_AspNetUsers_CheckedByUserId",
                        column: x => x.CheckedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FormStatus = table.Column<int>(type: "int", nullable: false),
                    InternalCodeOfMaterial = table.Column<int>(type: "int", nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalcedByUserId = table.Column<int>(type: "int", nullable: true),
                    CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedByUserId = table.Column<int>(type: "int", nullable: true),
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
                    ShiftMasterId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "FormSamplingFinishedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftMasterId = table.Column<int>(type: "int", nullable: true),
                    ProtocolNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskMasterId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSamplingFinishedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormSamplingFinishedProducts_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormSamplingFinishedProducts_AspNetUsers_TaskMasterId",
                        column: x => x.TaskMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormSamplingFinishedProducts_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormSettingUpTechnologicalEquipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSettingUpTechnologicalEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormSettingUpTechnologicalEquipments_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelAccessProtocols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProtocolNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProtocolDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelAccessProtocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonnelAccessProtocols_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionPersonnels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FullNameId = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionPersonnels_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckingProcedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormCheckingCheckweighingSettingId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Procedure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    ReferenceWeightOfGPPack = table.Column<double>(type: "float", nullable: false),
                    ActualWeightOfGPPack = table.Column<double>(type: "float", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExecutorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckingProcedures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckingProcedures_AspNetUsers_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CheckingProcedures_FormCheckingCheckweighingSettings_FormCheckingCheckweighingSettingId",
                        column: x => x.FormCheckingCheckweighingSettingId,
                        principalTable: "FormCheckingCheckweighingSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VerificationActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormCheckingRejectionOfDefectiveTabletId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Action = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    TaskMasterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerificationActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerificationActions_AspNetUsers_TaskMasterId",
                        column: x => x.TaskMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VerificationActions_FormCheckingRejectionOfDefectiveTablets_FormCheckingRejectionOfDefectiveTabletId",
                        column: x => x.FormCheckingRejectionOfDefectiveTabletId,
                        principalTable: "FormCheckingRejectionOfDefectiveTablets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackagingControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormControlOfPrimaryPackagingId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFoilCorrespondenceToSpecification = table.Column<bool>(type: "bit", nullable: false),
                    IsAppereanceWithoutDefects = table.Column<bool>(type: "bit", nullable: false),
                    IsClarityMarkAndCorrugationPattern = table.Column<bool>(type: "bit", nullable: false),
                    IsMatchingVariableData = table.Column<bool>(type: "bit", nullable: false),
                    IsBulkProductWithoutVisibleDamage = table.Column<bool>(type: "bit", nullable: false),
                    IsCorrespondsCountOfTabletsInBlister = table.Column<bool>(type: "bit", nullable: false),
                    ActualTemperatureOfCellFormingMin = table.Column<int>(type: "int", nullable: false),
                    ActualTemperatureOfCellFormingMax = table.Column<int>(type: "int", nullable: false),
                    ActualTemperatureOfBlisterAdhesion = table.Column<int>(type: "int", nullable: false),
                    BlisteringSpeed = table.Column<int>(type: "int", nullable: false),
                    TaskMasterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackagingControls_AspNetUsers_TaskMasterId",
                        column: x => x.TaskMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingControls_FormControlOfPrimaryPackagings_FormControlOfPrimaryPackagingId",
                        column: x => x.FormControlOfPrimaryPackagingId,
                        principalTable: "FormControlOfPrimaryPackagings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ExecutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementOfBulkProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementOfBulkProducts_AspNetUsers_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                        column: x => x.FormReceptionAndMovementOfBulkProductId,
                        principalTable: "FormReceptionAndMovementOfBulkProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionOfMaterials",
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
                    ShiftMasterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionOfMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceptionOfMaterials_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterials_FormReceptionAndMovementOfPackingMaterialId",
                        column: x => x.FormReceptionAndMovementOfPackingMaterialId,
                        principalTable: "FormReceptionAndMovementOfPackingMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SampleSelections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormSamplingFinishedProductId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountOfSampleSelection = table.Column<int>(type: "int", nullable: false),
                    EmployeeOKKId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleSelections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleSelections_AspNetUsers_EmployeeOKKId",
                        column: x => x.EmployeeOKKId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleSelections_FormSamplingFinishedProducts_FormSamplingFinishedProductId",
                        column: x => x.FormSamplingFinishedProductId,
                        principalTable: "FormSamplingFinishedProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabeProcedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormSamplingFinishedProductId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Procedure = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ExecutorId = table.Column<int>(type: "int", nullable: true),
                    CheckerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabeProcedures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabeProcedures_AspNetUsers_CheckerId",
                        column: x => x.CheckerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabeProcedures_AspNetUsers_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabeProcedures_FormSamplingFinishedProducts_FormSamplingFinishedProductId",
                        column: x => x.FormSamplingFinishedProductId,
                        principalTable: "FormSamplingFinishedProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SettingUpTechnologicalEquipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormSettingUpTechnologicalEquipmentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Action = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ServiceTechnicianId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingUpTechnologicalEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SettingUpTechnologicalEquipments_AspNetUsers_ServiceTechnicianId",
                        column: x => x.ServiceTechnicianId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SettingUpTechnologicalEquipments_FormSettingUpTechnologicalEquipments_FormSettingUpTechnologicalEquipmentId",
                        column: x => x.FormSettingUpTechnologicalEquipmentId,
                        principalTable: "FormSettingUpTechnologicalEquipments",
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
                name: "IX_CheckingProcedures_ExecutorId",
                table: "CheckingProcedures",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckingProcedures_FormCheckingCheckweighingSettingId",
                table: "CheckingProcedures",
                column: "FormCheckingCheckweighingSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_PackagingProtocolId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_TaskGivenId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "TaskGivenId");

            migrationBuilder.CreateIndex(
                name: "IX_ForMarkingThermalTransferLabelOnCorrugatedBoxes_TaskGotId",
                table: "ForMarkingThermalTransferLabelOnCorrugatedBoxes",
                column: "TaskGotId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCheckingCheckweighingSettings_PackagingProtocolId",
                table: "FormCheckingCheckweighingSettings",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCheckingRejectionOfDefectiveTablets_PackagingProtocolId",
                table: "FormCheckingRejectionOfDefectiveTablets",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormControlOfPrimaryPackagings_PackagingProtocolId",
                table: "FormControlOfPrimaryPackagings",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_CalcedByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_CheckedByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_CheckedPUByUserId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "CheckedPUByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_PackagingProtocolId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_ShiftMasterId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMaterialBalanceOfGpByLots_TaskMasterId",
                table: "FormMaterialBalanceOfGpByLots",
                column: "TaskMasterId");

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
                name: "IX_FormSamplingFinishedProducts_PackagingProtocolId",
                table: "FormSamplingFinishedProducts",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSamplingFinishedProducts_ShiftMasterId",
                table: "FormSamplingFinishedProducts",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSamplingFinishedProducts_TaskMasterId",
                table: "FormSamplingFinishedProducts",
                column: "TaskMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSettingUpTechnologicalEquipments_PackagingProtocolId",
                table: "FormSettingUpTechnologicalEquipments",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementOfBulkProducts_ExecutorId",
                table: "MovementOfBulkProducts",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementOfBulkProducts_FormReceptionAndMovementOfBulkProductId",
                table: "MovementOfBulkProducts",
                column: "FormReceptionAndMovementOfBulkProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingControls_FormControlOfPrimaryPackagingId",
                table: "PackagingControls",
                column: "FormControlOfPrimaryPackagingId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingControls_TaskMasterId",
                table: "PackagingControls",
                column: "TaskMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocols_ResponsibleUserOOKId",
                table: "PackagingProtocols",
                column: "ResponsibleUserOOKId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocols_ResponsibleUserTLFId",
                table: "PackagingProtocols",
                column: "ResponsibleUserTLFId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelAccessProtocols_PackagingProtocolId",
                table: "PersonnelAccessProtocols",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionPersonnels_FullNameId",
                table: "ProductionPersonnels",
                column: "FullNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionPersonnels_PackagingProtocolId",
                table: "ProductionPersonnels",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionOfMaterials_FormReceptionAndMovementOfPackingMaterialId",
                table: "ReceptionOfMaterials",
                column: "FormReceptionAndMovementOfPackingMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionOfMaterials_ShiftMasterId",
                table: "ReceptionOfMaterials",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleSelections_EmployeeOKKId",
                table: "SampleSelections",
                column: "EmployeeOKKId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleSelections_FormSamplingFinishedProductId",
                table: "SampleSelections",
                column: "FormSamplingFinishedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingUpTechnologicalEquipments_FormSettingUpTechnologicalEquipmentId",
                table: "SettingUpTechnologicalEquipments",
                column: "FormSettingUpTechnologicalEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingUpTechnologicalEquipments_ServiceTechnicianId",
                table: "SettingUpTechnologicalEquipments",
                column: "ServiceTechnicianId");

            migrationBuilder.CreateIndex(
                name: "IX_TabeProcedures_CheckerId",
                table: "TabeProcedures",
                column: "CheckerId");

            migrationBuilder.CreateIndex(
                name: "IX_TabeProcedures_ExecutorId",
                table: "TabeProcedures",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TabeProcedures_FormSamplingFinishedProductId",
                table: "TabeProcedures",
                column: "FormSamplingFinishedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_VerificationActions_FormCheckingRejectionOfDefectiveTabletId",
                table: "VerificationActions",
                column: "FormCheckingRejectionOfDefectiveTabletId");

            migrationBuilder.CreateIndex(
                name: "IX_VerificationActions_TaskMasterId",
                table: "VerificationActions",
                column: "TaskMasterId");
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
                name: "CheckingProcedures");

            migrationBuilder.DropTable(
                name: "ForMarkingThermalTransferLabelOnCorrugatedBoxes");

            migrationBuilder.DropTable(
                name: "FormMaterialBalanceOfGpByLots");

            migrationBuilder.DropTable(
                name: "MovementOfBulkProducts");

            migrationBuilder.DropTable(
                name: "PackagingControls");

            migrationBuilder.DropTable(
                name: "PersonnelAccessProtocols");

            migrationBuilder.DropTable(
                name: "ProductionPersonnels");

            migrationBuilder.DropTable(
                name: "ReceptionOfMaterials");

            migrationBuilder.DropTable(
                name: "SampleSelections");

            migrationBuilder.DropTable(
                name: "SettingUpTechnologicalEquipments");

            migrationBuilder.DropTable(
                name: "TabeProcedures");

            migrationBuilder.DropTable(
                name: "VerificationActions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "FormCheckingCheckweighingSettings");

            migrationBuilder.DropTable(
                name: "FormReceptionAndMovementOfBulkProducts");

            migrationBuilder.DropTable(
                name: "FormControlOfPrimaryPackagings");

            migrationBuilder.DropTable(
                name: "FormReceptionAndMovementOfPackingMaterials");

            migrationBuilder.DropTable(
                name: "FormSettingUpTechnologicalEquipments");

            migrationBuilder.DropTable(
                name: "FormSamplingFinishedProducts");

            migrationBuilder.DropTable(
                name: "FormCheckingRejectionOfDefectiveTablets");

            migrationBuilder.DropTable(
                name: "PackagingProtocols");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
