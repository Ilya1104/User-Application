﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserApp.Models
{
    public class User 
    {
        [Column("UserId")]               
        public Guid Id { get; set; }

      //  [Required(ErrorMessage = "Your name is required!")]
     //   [MaxLength(50, ErrorMessage = "You are entered a name greater than 50 symbols! ")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        [ForeignKey(nameof(UserRoles))]
        public Guid RoleId { get; set; }
        public UserRole UserRoles { get; set; }
        public User() { }
    }
} 
