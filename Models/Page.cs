using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserApp.Models
{
    public class Page
    {
        [Column("PageId")]
        public Guid Id { get; set; }
        public string Allowance { get; set; }       
    }
} 
