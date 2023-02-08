#nullable disable

using System.ComponentModel.DataAnnotations;

namespace BlazorFluentValidation.Data
{
    public class Person
    {
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
