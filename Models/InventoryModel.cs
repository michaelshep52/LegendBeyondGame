using System;
using System.ComponentModel.DataAnnotations;
using Legend.API.Data.Entities;

namespace Legend.API.Models
{
    public class InventoryModel
    {
        [Key]
        public int InventoryId { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Your character name must be at least 5 characters long.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The Damage field is required.")]
        [Range(1, 10, ErrorMessage = "Your base damage must be between 1 and 10.")]
        public int Damage { get; set; } = new Random().Next(1, 10);

        [Required(ErrorMessage = "The Type field is required.")]
        public string? Type { get; set; }

        [Required]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = false;

        //1 (Character) to Many (Inventory)
        public int CharacterId { get; set; }
        public Character? Character { get; set; }

    }
}

