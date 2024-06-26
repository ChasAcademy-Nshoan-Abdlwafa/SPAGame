﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPAGame.Models
{
    public class HighscoreModel
    {
        [Key]
        public int HighscoreId { get; set; }
        public int Score { get; set; }
        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public AccountModel Account { get; set; }
    }
}
