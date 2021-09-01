using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.EntityModels.Models;

namespace NanolekPrototype.Context
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
        public DbSet<PackagingProtocol> PackagingProtocols { get; set; }
        public DbSet<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProducts { get; set; }
        public DbSet<MovementOfBulkProduct> MovementOfBulkProducts { get; set; }
        public DbSet<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterials { get; set; }
        public DbSet<ReceptionOfMaterial> ReceptionOfMaterials { get; set; }
        public DbSet<FormSettingUpTechnologicalEquipment>  FormSettingUpTechnologicalEquipments { get; set; }
        public DbSet<SettingUpTechnologicalEquipment> SettingUpTechnologicalEquipments { get; set; }
        public DbSet<FormCheckingRejectionOfDefectiveTablet> FormCheckingRejectionOfDefectiveTablets { get; set; }
        public DbSet<VerificationAction> VerificationActions { get; set; }
        public DbSet<FormControlOfPrimaryPackaging> FormControlOfPrimaryPackagings { get; set; }
        public DbSet<PackagingControl> PackagingControls { get; set; }
        public DbSet<FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox> ForMarkingThermalTransferLabelOnCorrugatedBoxes
        {
            get;
            set;
        }
    }
}