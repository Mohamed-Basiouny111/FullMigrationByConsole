using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configuration
{
    internal class EmployeeDetailConfiguration : IEntityTypeConfiguration<EmployeeDetail>
    {
        public void Configure(EntityTypeBuilder<EmployeeDetail> builder)
        {
            builder.ToTable("EmployeeDetail");
            builder.HasKey("EmpId");
            builder.Property(c => c.Address)
                   .HasMaxLength(50);
            builder.Property(c => c.Country)
                   .HasMaxLength(50);

            builder.Property(c => c.State)
                   .HasMaxLength(50);

            builder.HasOne(d => d.Employee)
         .WithOne(e => e.EmployeeDetail)
         .HasForeignKey<EmployeeDetail>(d => d.EmpId);
        }
    }
}
