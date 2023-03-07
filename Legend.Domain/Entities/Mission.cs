using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Legend.Domain.Entities
{
    public class Mission
    {
       [Key]
        public int MissionId { get; set; }

        [Required(ErrorMessage = "Name cannot be null or empty")]
        [MinLength(3)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Text cannot be null or empty")]
        [MinLength(10)]
        public string? Text { get; set; }

        [Required]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        // 1 to Many,  1 Mission to  many Character
        public List<User>? Users { get; set; } = new List<User>();
    }
}