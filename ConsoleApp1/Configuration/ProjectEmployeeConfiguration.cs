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
    internal class ProjectEmployeeConfiguration : IEntityTypeConfiguration<ProjectEmployee>
    {
        public void Configure(EntityTypeBuilder<ProjectEmployee> builder)
        {
            builder.ToTable("ProjectEmployee");
            builder.HasKey(ct => new { ct.EmpId, ct.ProId }); // composite key

            //Many relation with Project 
            builder.HasOne(p => p.Project)
          .WithMany(c => c.ProjectEmployees)
          .HasForeignKey(p =>p.ProId);

            //Many relation with Employee 
            builder.HasOne(e => e.Employee)
          .WithMany(c => c.ProjectEmployees)
          .HasForeignKey(e => e.EmpId);
        }
    }
}
