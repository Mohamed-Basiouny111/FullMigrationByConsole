using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Models
{
    public class ProjectEmployee
    {
        public int EmpId { get; set; }
        public int ProId { get; set; }
        [MaxLength(100)]
        public string? Note { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }

}
