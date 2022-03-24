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
    public class PageConfiguration: IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.HasData
            (
                new Page
                {
                    Id = new Guid("98780c10-4a78-4e3d-a219-b08161878402"),
                    Allowance = "Editor"                  
                },
                new Page
                {
                    Id = new Guid("802d66a4-d17d-4643-810b-9daa62e21ed0"),
                    Allowance = "Viwer"
                }
                ,
                new Page
                {
                    Id = new Guid("086410cb-802e-4df1-8094-483af4b264ee"),
                    Allowance = "Field Worker"
                }
            );
        }
    }
} 
