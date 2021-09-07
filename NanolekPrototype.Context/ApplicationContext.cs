using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.EntityModels.Models;
using NanolekPrototype.EntityModels.Models.Employees;

namespace NanolekPrototype.Context
{
    public class ApplicationContext : IdentityDbContext<User,Role,int>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PackagingProtocol>()
                .HasOne(c => c.ResponsibleUserOOK)
                .WithMany(u => u.OOK)
                .HasForeignKey(x => x.ResponsibleUserOOKId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PackagingProtocol>()
                .HasOne(c => c.ResponsibleUserTLF)
                .WithMany(u => u.TLF)
                .HasForeignKey(x => x.ResponsibleUserTLFId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormReceptionAndMovementOfBulkProduct>()
                .HasOne(c => c.CalcedByUser)
                .WithMany(u=>u.Calcers)
                .HasForeignKey(x => x.CalcedByUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormReceptionAndMovementOfBulkProduct>()
                .HasOne(c => c.CheckedByUser)
                .WithMany(u => u.Checkers)
                .HasForeignKey(x => x.CheckedByUserId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }

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