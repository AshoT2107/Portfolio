using System.ComponentModel.DataAnnotations;

namespace PortfolioWeb.Entities
{
    public class ImageEntity
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(800)]
        public string? Description { get; set; }

        [Required]
        public string? URL { get; set; }

        public Guid UserId { get; set; }

        public UserEntity? User { get; set; }
    }
}
