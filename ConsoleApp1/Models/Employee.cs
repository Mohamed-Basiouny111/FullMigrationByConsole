using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string? LastName { get; set; }

        [ForeignKey("Department")]
        public int? DeptId { get; set; }

        //Navigation Properties 1:M
        public virtual Department Department { get; set; } 
        //Navigation Properties 1:1
        public virtual EmployeeDetail EmployeeDetail { get; set; } 
        //Navigation Properties M:M
        public virtual List<ProjectEmployee> ProjectEmployees { get; set; } = new List<ProjectEmployee>();
        // navigation to Self Relationship
        public int? ManagerId { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual List<Employee> ManagerList { get; set; } = new List<Employee>();

    }

}
