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
                .WithMany(u=>u.FormReceptionAndMovementOfBulkProductCalcers)
                .HasForeignKey(x => x.CalcedByUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormReceptionAndMovementOfBulkProduct>()
                .HasOne(c => c.CheckedByUser)
                .WithMany(u => u.FormReceptionAndMovementOfBulkProductCheckers)
                .HasForeignKey(x => x.CheckedByUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormReceptionAndMovementOfBulkProduct>()
                .HasOne(c => c.ShiftMaster)
                .WithMany(u => u.FormReceptionAndMovementOfBulkProductShiftMasters)
                .HasForeignKey(x => x.ShiftMasterId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormReceptionAndMovementOfPackingMaterial>()
                .HasOne(c => c.CalcedByUser)
                .WithMany(u => u.FormReceptionAndMovementOfPackingMaterialCalcers)
                .HasForeignKey(x => x.CalcedByUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormReceptionAndMovementOfPackingMaterial>()
                .HasOne(c => c.CheckedByUser)
                .WithMany(u => u.FormReceptionAndMovementOfPackingMaterialCheckers)
                .HasForeignKey(x => x.CheckedByUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormReceptionAndMovementOfPackingMaterial>()
                .HasOne(c => c.ShiftMaster)
                .WithMany(u => u.FormReceptionAndMovementOfPackingMaterialShiftMasters)
                .HasForeignKey(x => x.ShiftMasterId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TableReceptionOfMaterial>()
                .HasOne(c => c.ShiftMaster)
                .WithMany(u => u.TableReceptionOfMaterialShiftMasters)
                .HasForeignKey(x => x.ShiftMasterId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TableSettingUpTechnologicalEquipment>()
                .HasOne(c => c.ServiceTechnician)
                .WithMany(u => u.TableSettingUpTechnologicalEquipmentServiceTechnicians)
                .HasForeignKey(x => x.ServiceTechnicianId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TableVerificationAction>()
                .HasOne(c => c.TaskMaster)
                .WithMany(u => u.TableVerificationActionTaskMasters)
                .HasForeignKey(x => x.TaskMasterId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TablePackagingControl>()
                .HasOne(c => c.TaskMaster)
                .WithMany(u => u.TablePackagingControlTaskMasters)
                .HasForeignKey(x => x.TaskMasterId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox>()
                .HasOne(c => c.TaskGiven)
                .WithMany(u => u.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxTaskGivens)
                .HasForeignKey(x => x.TaskGivenId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox>()
                .HasOne(c => c.TaskGot)
                .WithMany(u => u.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxTaskGots)
                .HasForeignKey(x => x.TaskGotId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TableCheckingProcedure>()
                .HasOne(c => c.Executor)
                .WithMany(u => u.TableCheckingProcedureExecutors)
                .HasForeignKey(x => x.ExecutorId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.Entity<FormSamplingFinishedProduct>()
                .HasOne(c => c.ShiftMaster)
                .WithMany(u => u.FormSamplingFinishedProductShiftMasters)
                .HasForeignKey(x => x.ShiftMasterId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormSamplingFinishedProduct>()
                .HasOne(c => c.TaskMaster)
                .WithMany(u => u.FormSamplingFinishedProductTaskMasters)
                .HasForeignKey(x => x.TaskMasterId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TableProcedure>()
                .HasOne(c => c.Executor)
                .WithMany(u => u.TableProcedureExecutors)
                .HasForeignKey(x => x.ExecutorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TableProcedure>()
                .HasOne(c => c.Checker)
                .WithMany(u => u.TableProcedureCheckers)
                .HasForeignKey(x => x.CheckerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TableSampleSelection>()
                .HasOne(c => c.EmployeeOKK)
                .WithMany(u => u.TableSampleSelectionEmployeeOKKs)
                .HasForeignKey(x => x.EmployeeOKKId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormMaterialBalanceOfGPByLot>()
                .HasOne(c => c.ShiftMaster)
                .WithMany(u => u.FormMaterialBalanceOfGPByLotShiftMasters)
                .HasForeignKey(x => x.ShiftMasterId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormMaterialBalanceOfGPByLot>()
                .HasOne(c => c.CalcedByUser)
                .WithMany(u => u.FormMaterialBalanceOfGPByLotCalcedByUsers)
                .HasForeignKey(x => x.CalcedByUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormMaterialBalanceOfGPByLot>()
                .HasOne(c => c.CheckedByUser)
                .WithMany(u => u.FormMaterialBalanceOfGPByLotCheckedByUsers)
                .HasForeignKey(x => x.CheckedByUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormMaterialBalanceOfGPByLot>()
                .HasOne(c => c.CheckedPUByUser)
                .WithMany(u => u.FormMaterialBalanceOfGPByLotCheckedPUByUsers)
                .HasForeignKey(x => x.CheckedPUByUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<FormMaterialBalanceOfGPByLot>()
                .HasOne(c => c.TaskMaster)
                .WithMany(u => u.FormMaterialBalanceOfGPByLotTaskMasters)
                .HasForeignKey(x => x.TaskMasterId)
                .OnDelete(DeleteBehavior.NoAction);


            base.OnModelCreating(builder);
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
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
        public DbSet<FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox> FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox
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