using System;
using System.ComponentModel.DataAnnotations;
using Legend.API.Data.Entities;
using Microsoft.Extensions.Hosting;

namespace Legend.API.Models
{
    public class AccountModel
    {
        [Key]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "AccountName cannot be null or empty")]
        [MinLength(5)]
        public string? AccountName { get; set; }

        [Required(ErrorMessage = "Password cannot be null or empty")]
        [MinLength(8)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Firstname cannot be null or empty")]
        [MinLength(3)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Lastname cannot be null or empty")]
        [MinLength(4)]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email cannot be null or empty")]
        public string? Email { get; set; }

        [MinLength(10)]
        public string? Phone { get; set; }

        [Required]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = false;

        //public Character? Character { get; set; }
        //1 (User) to Many (Character)
        public List<Character>? Characters { get; set; }
    }
}

