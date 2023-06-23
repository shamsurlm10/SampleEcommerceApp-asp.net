﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.WebApp.Models
{
    public class CustomerCreate
    {
        [Required(ErrorMessage="Please provide name.")]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
