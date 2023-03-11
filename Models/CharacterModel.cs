using System;
using System.ComponentModel.DataAnnotations;
using Legend.API.Data;
using Legend.API.Data.Entities;

namespace Legend.API.Models
{
    public class CharacterModel
    {
        [Key]
        public int CharacterId { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Your character name must be at least 5 characters long.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The Health field is required.")]
        [Range(1, 10, ErrorMessage = "Your base health must be between 1 and 10.")]
        public int Health { get; set; } = new Random().Next(1, 10);

        [Required(ErrorMessage = "The Damage field is required.")]
        [Range(1, 10, ErrorMessage = "Your base damage must be between 1 and 10.")]
        public int Damage { get; set; } = new Random().Next(1, 10);

        [Required(ErrorMessage = "The Speed field is required.")]
        [Range(1, 10, ErrorMessage = "Your base Speed must be between 1 and 10.")]
        public int Speed { get; set; } = new Random().Next(1, 10);

        [Required(ErrorMessage = "The Stamina field is required.")]
        [Range(1, 10, ErrorMessage = "Your base stamina must be between 1 and 10.")]
        public int Stamina { get; set; } = new Random().Next(1, 10);

        /*[Required(ErrorMessage = "The Intelligence field is required.")]
        [Range(1, 10, ErrorMessage = "Your base intelligence must be between 1 and 10.")]
        public int Intelligence { get; set; } = new Random().Next(1, 10);

        [Required(ErrorMessage = "The Luck field is required.")]
        [Range(1, 10, ErrorMessage = "Your base luck must be between 1 and 10.")]
        public int Luck { get; set; } = new Random().Next(1, 10);*/

        [Required]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = false;

        //1 (Account) to Many (Character)
        public int AccountId { get; set; }
        public Account? Account { get; set; }

        //1 (Character) to Many (Inventory)
        public List<Inventory>? Inventories { get; set; }

    }
}

