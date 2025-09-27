using ConsoleApp1.Configuration;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class CompanyCodeFirstContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetail { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectEmployee> ProjectEmployees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Data Source =.;Initial Catalog=CompanyCodeFirst;Integrated Security=True;Trust Server Certificate=True;")
                 ;//.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>(e =>
            //{
            //    e.UseTphMappingStrategy();
            //});

            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());

            //All Assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Employee).Assembly);

            #region Use TPT strategy
            //modelBuilder.Entity<Employee>()
            //    .ToTable("Employees");   // جدول مشترك للخصائص العامة

            //modelBuilder.Entity<FullTimeEmployee>()
            //    .ToTable("FullTimeEmployees"); // الجدول ده بيحتوي على الأعمدة الإضافية لــ FullTimeEmployee

            //modelBuilder.Entity<PartTimeEmployee>()
            //    .ToTable("PartTimeEmployees"); // الجدول ده بيحتوي على الأعمدة الإضافية لــ PartTimeEmployee
            #endregion

            #region Use TPC strategy
            //modelBuilder.Entity<Employee>()
            //    .UseTpcMappingStrategy();  // مهم: يتعمل لمرة واحدة في الكلاس الأب

            //modelBuilder.Entity<FullTimeEmployee>()
            //    .ToTable("FullTimeEmployees");

            //modelBuilder.Entity<PartTimeEmployee>()
            //    .ToTable("PartTimeEmployees");
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
