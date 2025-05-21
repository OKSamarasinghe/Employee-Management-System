using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
    }
}
