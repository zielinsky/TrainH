using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainH.Models
{
    [Keyless]
    public class ExerciseData
    {
        [Required]
        public Exercise? Exercise { get; set; }
        [Required]
        public History? History { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
    }
}
