﻿namespace RECROBLR.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        // Foreign key
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
