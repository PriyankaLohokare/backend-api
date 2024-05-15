using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.DTOs
{
    public class EmployeeUpdateDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "First Name must contain only letters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Last Name must contain only letters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "BirthDate is required")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "JoiningDate is required")]
        public DateTime JoiningDate { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        public decimal Salary { get; set; }
    }
}
