using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserApp.Models
{
    public  class Admin
    {
        [Column("AdminId")]
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Post { get; set; }
    }
} 
