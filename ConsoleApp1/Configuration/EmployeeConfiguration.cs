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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.UseTphMappingStrategy();
            builder.HasOne(e=>e.Manager)
                    .WithMany(x=>x.ManagerList)
                    .HasForeignKey(e=>e.ManagerId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
