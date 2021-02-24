using System.ComponentModel.DataAnnotations.Schema;

namespace ByPassTheMovieAPI.VO
{
    [NotMapped]
    public class NameFilmVO
    {
        public string Title { get; set; }
        public string TitleIvers { get; set; }
    }
}
