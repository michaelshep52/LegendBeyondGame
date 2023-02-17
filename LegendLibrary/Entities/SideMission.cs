using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Legend.Domain.Entities
{
    public class SideMission
    {
        [Key]
        public int SideMissionId { get; set; }

        [Required(ErrorMessage = "Name cannot be null or empty")]
        [MinLength(3)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Text cannot be null or empty")]
        [MinLength(10)]
        public string? Text { get; set; }

        [Required]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        public List<Character> Characters { get; set; } = new List<Character>();

    }
}

