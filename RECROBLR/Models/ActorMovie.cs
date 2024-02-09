using System.ComponentModel.DataAnnotations;

namespace RECROBLR.Models
{
    public class ActorMovie
    {
        [Key]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
