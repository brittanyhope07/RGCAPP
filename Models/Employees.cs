using System.ComponentModel.DataAnnotations;

namespace RGCAPP.Models
{
    public class Employees
    {
        [Key]
        public System.Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
