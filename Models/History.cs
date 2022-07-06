using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainH.Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Kcal { get; set; }
        [Required]
        public User? User { get; set; }

    }
}
