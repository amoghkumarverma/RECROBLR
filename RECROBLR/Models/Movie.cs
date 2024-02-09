namespace RECROBLR.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        // Foreign keys
        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public List<ActorMovie> ActorMovies { get; set; }
        public List<Review> Reviews { get; set; }

        // Genre relationship
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
