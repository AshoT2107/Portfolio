using System.ComponentModel.DataAnnotations;

namespace PortfolioWeb.Entities
{
    public class UserEntity
    {

        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? UserName { get; set; }

        [Required]
        public string? Birthdate { get; set; }

        [Required]
        public string? Avatar { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Professions { get; set; }

        [Required]
        [MaxLength(500)]
        public string? Information { get; set; }

        public long? ChatId { get; set; }

        public ICollection<VideoEntity>? Videos { get; set; }

        public ICollection<ImageEntity>? Images { get; set; }

        [Required]
        public DateTime RegisterTime { get; set; } = DateTime.UtcNow;

    }
}
