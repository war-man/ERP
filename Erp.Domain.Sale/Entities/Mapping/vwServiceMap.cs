using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Domain.Sale.Entities.Mapping
{
    public class vwServiceMap : EntityTypeConfiguration<vwService>
    {
        public vwServiceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name).HasMaxLength(150);
            this.Property(t => t.Code).HasMaxLength(30);
            this.Property(t => t.Description).HasMaxLength(2000);
            this.Property(t => t.Unit).HasMaxLength(50);
            this.Property(t => t.Type).HasMaxLength(20);
            this.Property(t => t.CategoryCode).HasMaxLength(20);


            // Table & Column Mappings
            this.ToTable("vwSale_Service");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CreatedUserId).HasColumnName("CreatedUserId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedUserId).HasColumnName("ModifiedUserId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Name).HasColumnName("Name");

            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.PriceOutbound).HasColumnName("PriceOutbound");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.CategoryCode).HasColumnName("CategoryCode");
            this.Property(t => t.Barcode).HasColumnName("Barcode");
            this.Property(t => t.Image_Name).HasColumnName("Image_Name");
            this.Property(t => t.IsCombo).HasColumnName("IsCombo");
            this.Property(t => t.TimeForService).HasColumnName("TimeForService");
            //this.Property(t => t.DiscountStaff).HasColumnName("DiscountStaff");
            //this.Property(t => t.IsMoneyDiscount).HasColumnName("IsMoneyDiscount");
        }
    }
}
