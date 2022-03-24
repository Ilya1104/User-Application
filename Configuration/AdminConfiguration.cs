using UserApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserApp.Configuration
{
    public class AdminConfiguration: IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData
            (
                new Admin
                {
                    Id = new Guid("285c1dca-748d-41fc-87fc-4f779afe1d96"),
                    Login = "Admin1",
                    Password = "46564",
                    Post = "Lead Admin"
                },
                new Admin
                {
                    Id = new Guid("35f701f3-3d03-4c69-b0ec-9688e8abe19e"),
                    Login = "Admin2",
                    Password = "132312",
                    Post = "Middle Admin"
                }
                ,
                new Admin
                {
                    Id = new Guid("f17058d9-46d0-4f42-b28a-1b168a713f50"),
                    Login = "Admin3",
                    Password = "963852",
                    Post = "Junior Admin"
                }
            );
        }
    }
} 
