using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Models
{
    [Table("Project")]
    public class Project
    {
        [Key]
        public int ProjId { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        [MaxLength (100)]
        public string? Description { get; set; }

        public virtual List<ProjectEmployee> ProjectEmployees { get; set; } = new List<ProjectEmployee>();
    }

}
