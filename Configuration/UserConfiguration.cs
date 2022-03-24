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
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new User
                {
                    Id = new Guid("753fd9fb-e3a5-4188-bf3b-95fc0ef6d0b7"),
                    Name = "Ilya",
                    Surname = "Kuzhanov",
                    Age = 19,
                    Login = "Ilya228",
                    Password = "123456", 
                    RoleId = new Guid("1820fb8d-66cf-4a49-adf7-de943ea9e3d7")
                },
                new User
                {
                    Id = new Guid("af301fd9-08d8-44ae-a255-6d138c8e000a"),
                    Name = "Petr",
                    Surname = "Petrov",
                    Age = 35,
                    Login = "PetrPerviy",
                    Password = "332211",
                    RoleId = new Guid("1c1f366b-7e15-455d-b193-20520c3d1b20")
                }
                ,
                new User
                {
                    Id = new Guid("66e9c50e-7994-4301-a5fe-4e29c88432e0"),
                    Name = "Ivan",
                    Surname = "Ivanov",
                    Age = 40,
                    Login = "Vanyaaa",
                    Password = "45645",
                    RoleId = new Guid("60ad944d-a773-426f-a92d-f0e7b9921086")
                }
            );
        }
    }
} 
