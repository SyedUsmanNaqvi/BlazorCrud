using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Models
{
    public class Person
    {
        public int Id { get; set; }
      
        [Required]
        public string? Name { get; set; }
        [Required,EmailAddress]
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? phoneNumber { get; set; }
        public bool IsDraft { get; set; } 
    }
}
