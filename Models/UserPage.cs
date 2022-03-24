using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserApp.Models
{
    public class UserPage
    {
        [Column("UserPageId")]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }



        [ForeignKey(nameof(Admin))]
        public Guid AdminId { get; set; }
        public Admin Admin { get; set; }


        [ForeignKey(nameof(Page))]
        public Guid PageId { get; set; }
        public Page Page { get; set; }
    }
} 
