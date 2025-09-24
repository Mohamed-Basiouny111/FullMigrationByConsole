using ConsoleApp1.Data;
using ConsoleApp1.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyCodeFirstContext db = new();
            Console.WriteLine("Hello, World!");
            //  db.Database.EnsureDeleted();
            #region ِAddDepartment
            //db.Departments.AddRange(
            //    new Department() { Name = "IS", Description = "Hello" },
            //    new Department() { Name = "CS", Description = "Hello" },
            //    new Department() { Name = "IT", Description = "Hello" },
            //    new Department() { Name = "SE", Description = "Hello" },
            //    new Department() { Name = "BIS", Description = "Hello" },
            //    new Department() { Name = "ENG", Description = "Hello" }

            //);
            //db.SaveChanges();
            #endregion

            #region Add Employee
            //db.Employees.AddRange(
            //    new FullTimeEmployee() { FirstName = "Mohamed", LastName = "Basiouny", Salary = 10000, Bonus = 500, DeptId = 2 },
            //    new FullTimeEmployee() { FirstName = "Ahmed", LastName = "Esmail", Salary = 10000, Bonus = 500, DeptId = 1,ManagerId=1 },
            //    new FullTimeEmployee() { FirstName = "Ali", LastName = "Ibraheem", Salary = 10000, Bonus = 500, DeptId = 3, ManagerId = 1 },
            //    new FullTimeEmployee() { FirstName = "Omar ", LastName = "Mohamed", Salary = 10000, Bonus = 500, DeptId = 4, ManagerId = 1 },

            //    new PartTimeEmployee() { FirstName = "yaser ", LastName = "Mohamed", Hour = 150, Deductions = 500, DeptId = 2, ManagerId = 5 },
            //    new PartTimeEmployee() { FirstName = "tallat", LastName = "Mohamed", Hour = 150, Deductions = 500, DeptId = 1, ManagerId = 5 },
            //    new PartTimeEmployee() { FirstName = "omar ", LastName = "Mohamed", Hour = 150, Deductions = 500, DeptId = 3, ManagerId = 5 }

            //);
            //db.SaveChanges();
            #endregion
         
            

            #region Run SQL in EF
            //var result = db.Employees.FromSql($"select * from Employees"); //return select * only
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.FirstName);
            //}
            #endregion

            #region tracking & AsNoTracking
            //var emp = db.Employees.FirstOrDefault(e => e.Id == 1);
            //Console.WriteLine(db.Entry(emp).State);//Unchanged
            //emp.Name = "Mohamed Basiouny";
            //Console.WriteLine(db.Entry(emp).State);//Modified 

            //var emp = db.Employees.AsNoTracking().FirstOrDefault(e => e.Id == 1);//can't add changes
            //emp.Name = "Mohamed Basiouny";
            //Console.WriteLine(db.Entry(emp).State);//Detached 
            #endregion

            #region Loading strategies
            //Eager Loading
            //var dept = db.Departments.Include(e=>e.Employees).FirstOrDefault(e => e.Id == 1);
            //foreach (var item in dept.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Explicit Load
            //Collection
            //var dept = db.Departments.FirstOrDefault(e => e.Id == 1);
            //db.Entry(dept).Collection(c => c.Employees).Load();
            //foreach (var item in dept.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //References
            //var emp = db.Employees.FirstOrDefault(e => e.Id == 1);
            //db.Entry(emp).Reference(e=>e.Department).Load();       
            //Console.WriteLine(emp.Name);

            //Lazy Load
            //var dept = db.Departments.FirstOrDefault(e => e.Id == 1);
            //foreach (var item in dept.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region Stored Procedure
            //var deptIdParam = new SqlParameter("@DeptId", 2);

            //var result = db.Employees
            //               .FromSqlRaw("EXEC GetEmployeesByDeptId @DeptId", deptIdParam)
            //               .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.FirstName);
            //} 
            #endregion
        }
    }
}
