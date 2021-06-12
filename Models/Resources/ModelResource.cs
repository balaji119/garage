using System.ComponentModel.DataAnnotations;

namespace garage.Models.Resources
{
    public class ModelResource
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}