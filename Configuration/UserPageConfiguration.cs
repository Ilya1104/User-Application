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
    public class UserPageConfiguration: IEntityTypeConfiguration<UserPage>
    {
        public void Configure(EntityTypeBuilder<UserPage> builder)
        {
            builder.HasData
            (
                new UserPage
                {
                    Id = new Guid("00ea78cb-8c55-49cb-b1b4-fb23ec5e1780"),
                    UserId = new Guid("753fd9fb-e3a5-4188-bf3b-95fc0ef6d0b7"),
                    AdminId = new Guid("285c1dca-748d-41fc-87fc-4f779afe1d96"),
                    PageId = new Guid("98780c10-4a78-4e3d-a219-b08161878402")
                },
                new UserPage
                {
                    Id = new Guid("c71507e1-1996-4c71-9ea6-9590524b29e9"),
                    UserId = new Guid("af301fd9-08d8-44ae-a255-6d138c8e000a"),
                    AdminId = new Guid("35f701f3-3d03-4c69-b0ec-9688e8abe19e"),
                    PageId = new Guid("802d66a4-d17d-4643-810b-9daa62e21ed0")
                }
                ,
                new UserPage
                {
                    Id = new Guid("5859ecfc-5aae-4063-aae7-667fcec51f26"),
                    UserId = new Guid("66e9c50e-7994-4301-a5fe-4e29c88432e0"),
                    AdminId = new Guid("f17058d9-46d0-4f42-b28a-1b168a713f50"),
                    PageId = new Guid("086410cb-802e-4df1-8094-483af4b264ee")
                }
            );
        }
    }
} 
