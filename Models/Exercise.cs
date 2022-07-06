using System.ComponentModel.DataAnnotations;

namespace TrainH.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
