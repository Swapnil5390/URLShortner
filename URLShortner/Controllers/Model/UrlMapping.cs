using System.ComponentModel.DataAnnotations;

namespace URLShortner.Controllers.Model
{
    public class UrlMapping
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string OrignalUrl { get; set; } = string.Empty;

        [Required]
        public string ShortenUrl { get; set; } = string.Empty;

        public string longUrl { get; set; } = string.Empty;

    }

}
