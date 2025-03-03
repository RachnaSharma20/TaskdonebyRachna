using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class UserModel
    {
        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
