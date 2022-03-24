using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserApp.Models
{
    public class UserRole
    {
        [Column("RoleId")]
        public Guid Id { get; set; }
        public string Name { get; set; }  
        public IEnumerable<User> Users { get; set; } 
    }
} 
