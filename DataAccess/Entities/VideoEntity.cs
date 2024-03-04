﻿using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class VideoEntity
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

        [Required]
        public string? Poster { get; set; }
        
        [Required]
        public Guid? UserId { get; set; }

        public UserEntity? User { get; set; }    

        public virtual ICollection<ImageEntity>? Images { get; set; }

    }
}
