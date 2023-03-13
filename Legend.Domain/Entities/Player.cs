using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legend.Domain.Entities
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public int AccountId { get; set; }
        public int CharacterId { get; set; }
        public int InventoryId { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account? Account { get; set; }

        [ForeignKey("CharacterId")]
        public virtual Character? Character { get; set; }

        [ForeignKey("InventoryId")]
        public virtual Inventory? Inventory { get; set; }

    }
}

