using System;
using System.ComponentModel.DataAnnotations;

namespace Legend.Domain.Entities
{
    public class Weapon
    {
        [Key]
        public int WeaponId { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Name must be at least 4 characters long.")]
        public string? Name { get; set; }

        [Required]
        [Range(0, 20, ErrorMessage = "Equipment's base attack must be between 0 and 20.")]
        public int Attack { get; set; } = 0;

        [Required]
        [Range(0, 20, ErrorMessage = "Equipment's base defense must be between 0 and 20.")]
        public int Defense { get; set; } = 0;

        [Required]
        [Range(0, 20, ErrorMessage = "Equipment's base duration must be between 0 and 20.")]
        public int Duration { get; set; } = 0;

        public List<Character> Characters { get; set; } = new List<Character>();
    }
}

