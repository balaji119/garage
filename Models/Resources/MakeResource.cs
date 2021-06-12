using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace garage.Models.Resources
{
    public class MakeResource
    {
        public MakeResource()
        {
            Models = new Collection<ModelResource>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<ModelResource> Models { get; set; }
    }
}