﻿using System.ComponentModel.DataAnnotations;

namespace Notiflex.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        public string Email { get; set; } = null!;
    }
}
