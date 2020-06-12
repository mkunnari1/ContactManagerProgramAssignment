using System.ComponentModel.DataAnnotations;

namespace ContactManager.ViewModels
{
    public class DeleteContact
    {
        public int Id { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
