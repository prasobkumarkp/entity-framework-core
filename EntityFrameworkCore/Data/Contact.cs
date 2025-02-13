﻿using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Data
{
    public class Contact:BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
    }
}
