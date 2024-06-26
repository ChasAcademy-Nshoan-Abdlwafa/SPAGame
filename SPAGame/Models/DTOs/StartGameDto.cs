﻿namespace SPAGame.Models.DTOs
{
    public class StartGameDto
    {
        public int AccountId { get; set; }
        public int GameNumber { get; set; }
        public int GameAttempts { get; set; }
        public bool GameActive { get; set; }
        public DateTime GameDate { get; set; }
    }
}
