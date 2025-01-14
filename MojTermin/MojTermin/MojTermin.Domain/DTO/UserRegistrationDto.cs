﻿using MojTermin.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MojTermin.Domain.DTO
{
    public class UserRegistrationDto
    {
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Address is required")]
        [StringLength(100)]
        public string Address { get; set; }

        //[Required(ErrorMessage = "Role is required")]
        public Guid Role { get; set; }


        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "The Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
