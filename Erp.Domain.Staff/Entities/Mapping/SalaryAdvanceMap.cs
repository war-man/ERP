using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Domain.Staff.Entities.Mapping
{
    public class SalaryAdvanceMap : EntityTypeConfiguration<SalaryAdvance>
    {
        public SalaryAdvanceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CodeAdvance).HasMaxLength(150);
                        this.Property(t => t.Status).HasMaxLength(50);


            // Table & Column Mappings
            this.ToTable("Staff_SalaryAdvance");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CreatedUserId).HasColumnName("CreatedUserId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedUserId).HasColumnName("ModifiedUserId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.AssignedUserId).HasColumnName("AssignedUserId");
            this.Property(t => t.CodeAdvance).HasColumnName("CodeAdvance");

            this.Property(t => t.Pay).HasColumnName("Pay");
            this.Property(t => t.StaffId).HasColumnName("StaffId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.DayAdvance).HasColumnName("DayAdvance");
        }
    }
}
