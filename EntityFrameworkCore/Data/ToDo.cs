using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Data
{
    public class ToDo:BaseEntity
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public bool Completed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CompletedAt { get; set; }
    }
}
