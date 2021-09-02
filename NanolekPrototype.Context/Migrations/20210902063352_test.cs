using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NanolekPrototype.Context.Migrations
{
    public partial class test : Migration
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
                name: "PackagingProtocolForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GTIN = table.Column<int>(type: "int", nullable: true),
                    Series = table.Column<int>(type: "int", nullable: true),
                    DateOfManufacture = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PacksInCorrugatedBox = table.Column<int>(type: "int", nullable: true),
                    InternalCode = table.Column<int>(type: "int", nullable: true),
                    TaskGivenId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskGivenDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskGotId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskGotDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDateOfPacking = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDateOfPacking = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FormMaterialBalanceOfGPByLot_ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ShiftMasterDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FormMaterialBalanceOfGPByLot_CalcedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FormMaterialBalanceOfGPByLot_CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FormMaterialBalanceOfGPByLot_CheckedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FormMaterialBalanceOfGPByLot_CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckedPUByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedPUByUserDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PackagesCount = table.Column<int>(type: "int", nullable: true),
                    ExitAccordingToTheRegulations = table.Column<int>(type: "int", nullable: true),
                    IsCompliant = table.Column<bool>(type: "bit", nullable: true),
                    FormMaterialBalanceOfGPByLot_Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormMaterialBalanceOfGPByLot_TaskMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FormMaterialBalanceOfGPByLot_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FormReceptionAndMovementOfBulkProduct_InternalCodeOfMaterial = table.Column<int>(type: "int", nullable: true),
                    FormReceptionAndMovementOfBulkProduct_Specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormReceptionAndMovementOfBulkProduct_CalcedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FormReceptionAndMovementOfBulkProduct_CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FormReceptionAndMovementOfBulkProduct_CheckedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FormReceptionAndMovementOfBulkProduct_CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FormReceptionAndMovementOfBulkProduct_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GetPRP = table.Column<int>(type: "int", nullable: true),
                    PartSAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrespondToControlIndicators = table.Column<bool>(type: "bit", nullable: true),
                    IsCorrespondToShelfLife = table.Column<bool>(type: "bit", nullable: true),
                    FormReceptionAndMovementOfBulkProduct_ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EntredIntoGPPackages = table.Column<int>(type: "int", nullable: true),
                    EntredIntoGPUnits = table.Column<int>(type: "int", nullable: true),
                    GarbageUnits = table.Column<int>(type: "int", nullable: true),
                    DefectFirstPackageUnits = table.Column<int>(type: "int", nullable: true),
                    SampleSelectionUnits = table.Column<int>(type: "int", nullable: true),
                    GarbageSecondPackageUnits = table.Column<int>(type: "int", nullable: true),
                    FormStatus = table.Column<int>(type: "int", nullable: true),
                    InternalCodeOfMaterial = table.Column<int>(type: "int", nullable: true),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalcedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CalcedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedByUserDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SpentOnBatch = table.Column<int>(type: "int", nullable: true),
                    RemainingMaterial = table.Column<int>(type: "int", nullable: true),
                    IsSentToStorage = table.Column<bool>(type: "bit", nullable: true),
                    IsStoredInProduction = table.Column<bool>(type: "bit", nullable: true),
                    ExpenseFor1000Packs = table.Column<int>(type: "int", nullable: true),
                    IsCorrespondsToConsumptionRate = table.Column<bool>(type: "bit", nullable: true),
                    Reconciliation = table.Column<int>(type: "int", nullable: true),
                    IsCorrespondenceEligibilityCriteria = table.Column<bool>(type: "bit", nullable: true),
                    FormReceptionAndMovementOfPackingMaterial_Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormReceptionAndMovementOfPackingMaterial_ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FormReceptionAndMovementOfPackingMaterial_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NotificationNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProtocolNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingProtocolForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_CalcedByUserId",
                        column: x => x.CalcedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_CheckedByUserId",
                        column: x => x.CheckedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_CheckedPUByUserId",
                        column: x => x.CheckedPUByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_CalcedByUserId",
                        column: x => x.FormMaterialBalanceOfGPByLot_CalcedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_CheckedByUserId",
                        column: x => x.FormMaterialBalanceOfGPByLot_CheckedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_ShiftMasterId",
                        column: x => x.FormMaterialBalanceOfGPByLot_ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_FormMaterialBalanceOfGPByLot_TaskMasterId",
                        column: x => x.FormMaterialBalanceOfGPByLot_TaskMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfBulkProduct_CalcedByUserId",
                        column: x => x.FormReceptionAndMovementOfBulkProduct_CalcedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfBulkProduct_CheckedByUserId",
                        column: x => x.FormReceptionAndMovementOfBulkProduct_CheckedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfBulkProduct_ShiftMasterId",
                        column: x => x.FormReceptionAndMovementOfBulkProduct_ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_FormReceptionAndMovementOfPackingMaterial_ShiftMasterId",
                        column: x => x.FormReceptionAndMovementOfPackingMaterial_ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_ShiftMasterId",
                        column: x => x.ShiftMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_TaskGivenId",
                        column: x => x.TaskGivenId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_TaskGotId",
                        column: x => x.TaskGotId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_AspNetUsers_TaskMasterId",
                        column: x => x.TaskMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagingProtocolForms_PackagingProtocols_PackagingProtocolId",
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
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductionPersonnels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackagingProtocolId = table.Column<long>(type: "bigint", nullable: true),
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
                        name: "FK_ProductionPersonnels_PackagingProtocols_PackagingProtocolId",
                        column: x => x.PackagingProtocolId,
                        principalTable: "PackagingProtocols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    ExecutorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_CheckingProcedures_PackagingProtocolForms_FormCheckingCheckweighingSettingId",
                        column: x => x.FormCheckingCheckweighingSettingId,
                        principalTable: "PackagingProtocolForms",
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
                        name: "FK_MovementOfBulkProducts_PackagingProtocolForms_FormReceptionAndMovementOfBulkProductId",
                        column: x => x.FormReceptionAndMovementOfBulkProductId,
                        principalTable: "PackagingProtocolForms",
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
                    TaskMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_PackagingControls_PackagingProtocolForms_FormControlOfPrimaryPackagingId",
                        column: x => x.FormControlOfPrimaryPackagingId,
                        principalTable: "PackagingProtocolForms",
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
                    ShiftMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_ReceptionOfMaterials_PackagingProtocolForms_FormReceptionAndMovementOfPackingMaterialId",
                        column: x => x.FormReceptionAndMovementOfPackingMaterialId,
                        principalTable: "PackagingProtocolForms",
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
                    EmployeeOKKId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_SampleSelections_PackagingProtocolForms_FormSamplingFinishedProductId",
                        column: x => x.FormSamplingFinishedProductId,
                        principalTable: "PackagingProtocolForms",
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
                    ServiceTechnicianId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_SettingUpTechnologicalEquipments_PackagingProtocolForms_FormSettingUpTechnologicalEquipmentId",
                        column: x => x.FormSettingUpTechnologicalEquipmentId,
                        principalTable: "PackagingProtocolForms",
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
                    ExecutorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_TabeProcedures_PackagingProtocolForms_FormSamplingFinishedProductId",
                        column: x => x.FormSamplingFinishedProductId,
                        principalTable: "PackagingProtocolForms",
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
                    TaskMasterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_VerificationActions_PackagingProtocolForms_FormCheckingRejectionOfDefectiveTabletId",
                        column: x => x.FormCheckingRejectionOfDefectiveTabletId,
                        principalTable: "PackagingProtocolForms",
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
                name: "IX_PackagingProtocolForms_CalcedByUserId",
                table: "PackagingProtocolForms",
                column: "CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_CheckedByUserId",
                table: "PackagingProtocolForms",
                column: "CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_CheckedPUByUserId",
                table: "PackagingProtocolForms",
                column: "CheckedPUByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_CalcedByUserId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_CheckedByUserId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormMaterialBalanceOfGPByLot_TaskMasterId",
                table: "PackagingProtocolForms",
                column: "FormMaterialBalanceOfGPByLot_TaskMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_CalcedByUserId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_CalcedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_CheckedByUserId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_CheckedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfBulkProduct_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfBulkProduct_ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_FormReceptionAndMovementOfPackingMaterial_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "FormReceptionAndMovementOfPackingMaterial_ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_PackagingProtocolId",
                table: "PackagingProtocolForms",
                column: "PackagingProtocolId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_ShiftMasterId",
                table: "PackagingProtocolForms",
                column: "ShiftMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_TaskGivenId",
                table: "PackagingProtocolForms",
                column: "TaskGivenId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_TaskGotId",
                table: "PackagingProtocolForms",
                column: "TaskGotId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingProtocolForms_TaskMasterId",
                table: "PackagingProtocolForms",
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
                name: "PackagingProtocolForms");

            migrationBuilder.DropTable(
                name: "PackagingProtocols");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
