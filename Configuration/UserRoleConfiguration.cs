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
    public class UserRoleConfiguration: IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData
            (
                new UserRole
                {
                    Id = new Guid("1820fb8d-66cf-4a49-adf7-de943ea9e3d7"),
                    Name = "Editor"                  
                },
                new UserRole
                {
                    Id = new Guid("1c1f366b-7e15-455d-b193-20520c3d1b20"),
                    Name = "Viwer"
                }
                ,
                new UserRole
                {
                    Id = new Guid("60ad944d-a773-426f-a92d-f0e7b9921086"),
                    Name = "Field Worker"
                }
            );
        }
    }
} 
