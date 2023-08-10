namespace Dapper.SimpleCRUD.Core.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCountry { get; set; }
    }
}