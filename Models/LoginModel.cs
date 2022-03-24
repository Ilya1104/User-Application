using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Enter a login!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Enter a password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
} 
