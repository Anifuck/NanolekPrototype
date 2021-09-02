using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.EntityModels.Models;

namespace NanolekPrototype.Context
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    //builder.Entity<TablePersonnelAccessProtocol>()
        //    //    .HasOne(c => c.PackagingProtocol)
        //    //    .WithMany(c => c.PersonnelAccessProtocols)
        //    //    .HasForeignKey(x => x.PackagingProtocolId);
        //    //base.OnModelCreating(builder);
        //}

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
        public DbSet<PackagingProtocol> PackagingProtocols { get; set; }
        public DbSet<TableProductionPersonnel> ProductionPersonnels { get; set; }
        public DbSet<TablePersonnelAccessProtocol> PersonnelAccessProtocols { get; set; }
        public DbSet<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProducts { get; set; }
        public DbSet<TableMovementOfBulkProduct> MovementOfBulkProducts { get; set; }
        public DbSet<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterials { get; set; }
        public DbSet<TableReceptionOfMaterial> ReceptionOfMaterials { get; set; }
        public DbSet<FormSettingUpTechnologicalEquipment>  FormSettingUpTechnologicalEquipments { get; set; }
        public DbSet<TableSettingUpTechnologicalEquipment> SettingUpTechnologicalEquipments { get; set; }
        public DbSet<FormCheckingRejectionOfDefectiveTablet> FormCheckingRejectionOfDefectiveTablets { get; set; }
        public DbSet<TableVerificationAction> VerificationActions { get; set; }
        public DbSet<FormControlOfPrimaryPackaging> FormControlOfPrimaryPackagings { get; set; }
        public DbSet<TablePackagingControl> PackagingControls { get; set; }
        public DbSet<FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox> ForMarkingThermalTransferLabelOnCorrugatedBoxes
        {
            get;
            set;
        }
        public DbSet<FormCheckingCheckweighingSetting> FormCheckingCheckweighingSettings { get; set; }
        public DbSet<TableCheckingProcedure> CheckingProcedures { get; set; }

        public DbSet<FormSamplingFinishedProduct> FormSamplingFinishedProducts { get; set; }
        public DbSet<TableSampleSelection> SampleSelections { get; set; }
        public DbSet<TableProcedure> TabeProcedures { get; set; }
        public DbSet<FormMaterialBalanceOfGPByLot> FormMaterialBalanceOfGpByLots { get; set; }
    }
}