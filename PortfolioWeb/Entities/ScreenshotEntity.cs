using System.ComponentModel.DataAnnotations;

namespace PortfolioWeb.Entities
{
    public class ScreenshotEntity
    {

        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        public string? URL { get; set; }

        public Guid VideoId { get; set; }

        public VideoEntity? Video { get; set; }

    }
}