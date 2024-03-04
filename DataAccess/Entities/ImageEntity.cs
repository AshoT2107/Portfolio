using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class ImageEntity
    {

        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Description { get; set; }

        [Required]
        public string? URL { get; set; }

        public Guid VideoId { get; set; }

        public VideoEntity? Video { get; set; }

        public Guid UserId { get; set; }

        public UserEntity? User { get; set; }

    }
}