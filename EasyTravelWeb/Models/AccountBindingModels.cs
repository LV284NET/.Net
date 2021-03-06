﻿using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace EasyTravelWeb.Models
{
    // Models used as parameters to AccountController actions.

    /// <summary>
    ///    Identity AddExternalLoginBindingModel
    /// </summary>

    public class AddExternalLoginBindingModel
    {
        /// <summary>
        ///    
        /// </summary>
        [Required]
        [Display(Name = "External access token")]
        public string ExternalAccessToken { get; set; }
    }

    /// <summary>
    ///    
    /// </summary>
    public class ChangePasswordBindingModel
    {
        /// <summary>
        ///    
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        /// <summary>
        ///    
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        /// <summary>
        ///    
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangeFirstName
    {
        /// <summary>
        ///    
        /// </summary>
        [Required]
        [Display(Name = "New First Name")]
        public string newFirstName { get; set; }
    }

    public class ChangeLastName
    {
        /// <summary>
        ///    
        /// </summary>
        [Required]
        [Display(Name = "New Last Name")]
        public string newLastName { get; set; }
    }

    /// <summary>
    ///    
    /// </summary>
    public class RegisterBindingModel
    {
        /// <summary>
        ///    
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        ///    
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        ///    
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        ///    
        /// </summary>
        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        ///    
        /// </summary>
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
    }

    /// <summary>
    ///    
    /// </summary>
    public class RegisterExternalBindingModel
    {
        /// <summary>
        ///    
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    /// <summary>
    ///    
    /// </summary>
    public class RemoveLoginBindingModel
    {
        /// <summary>
        ///    
        /// </summary>
        [Required]
        [Display(Name = "Login provider")]
        public string LoginProvider { get; set; }

        /// <summary>
        ///    
        /// </summary>
        [Required]
        [Display(Name = "Provider key")]
        public string ProviderKey { get; set; }
    }

    /// <summary>
    ///    
    /// </summary>
    public class SetPasswordBindingModel
    {
        /// <summary>
        ///    
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        /// <summary>
        ///    
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
