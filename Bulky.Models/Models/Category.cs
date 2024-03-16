using System.ComponentModel.DataAnnotations;

namespace Bulky.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1, 200, ErrorMessage = "Display Order for category must be between 1 and 200")]
        public int DisplayOrder { get; set; }
    }
}
