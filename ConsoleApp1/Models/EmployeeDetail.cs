namespace ConsoleApp1.Models
{
    //useing Fluent Api
    public class EmployeeDetail
    {
        public int EmpId { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public int? Zipcode { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

        //Navigation Properties
        public virtual Employee Employee { get; set; } 
    }
}
