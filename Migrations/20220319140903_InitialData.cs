using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserApp.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "Login", "Password", "Post" },
                values: new object[,]
                {
                    { new Guid("285c1dca-748d-41fc-87fc-4f779afe1d96"), "Admin1", "46564", "Lead Admin" },
                    { new Guid("35f701f3-3d03-4c69-b0ec-9688e8abe19e"), "Admin2", "132312", "Middle Admin" },
                    { new Guid("f17058d9-46d0-4f42-b28a-1b168a713f50"), "Admin3", "963852", "Junior Admin" }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "PageId", "Allowance" },
                values: new object[,]
                {
                    { new Guid("98780c10-4a78-4e3d-a219-b08161878402"), "Editor" },
                    { new Guid("802d66a4-d17d-4643-810b-9daa62e21ed0"), "Viwer" },
                    { new Guid("086410cb-802e-4df1-8094-483af4b264ee"), "Field Worker" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { new Guid("1820fb8d-66cf-4a49-adf7-de943ea9e3d7"), "Editor" },
                    { new Guid("1c1f366b-7e15-455d-b193-20520c3d1b20"), "Viwer" },
                    { new Guid("60ad944d-a773-426f-a92d-f0e7b9921086"), "Field Worker" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Login", "Name", "Password", "RoleId", "Surname" },
                values: new object[] { new Guid("753fd9fb-e3a5-4188-bf3b-95fc0ef6d0b7"), 19, "Ilya228", "Ilya", "123456", new Guid("1820fb8d-66cf-4a49-adf7-de943ea9e3d7"), "Kuzhanov" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Login", "Name", "Password", "RoleId", "Surname" },
                values: new object[] { new Guid("af301fd9-08d8-44ae-a255-6d138c8e000a"), 35, "PetrPerviy", "Petr", "332211", new Guid("1c1f366b-7e15-455d-b193-20520c3d1b20"), "Petrov" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Login", "Name", "Password", "RoleId", "Surname" },
                values: new object[] { new Guid("66e9c50e-7994-4301-a5fe-4e29c88432e0"), 40, "Vanyaaa", "Ivan", "45645", new Guid("60ad944d-a773-426f-a92d-f0e7b9921086"), "Ivanov" });

            migrationBuilder.InsertData(
                table: "UserPages",
                columns: new[] { "UserPageId", "AdminId", "PageId", "UserId" },
                values: new object[] { new Guid("00ea78cb-8c55-49cb-b1b4-fb23ec5e1780"), new Guid("285c1dca-748d-41fc-87fc-4f779afe1d96"), new Guid("98780c10-4a78-4e3d-a219-b08161878402"), new Guid("753fd9fb-e3a5-4188-bf3b-95fc0ef6d0b7") });

            migrationBuilder.InsertData(
                table: "UserPages",
                columns: new[] { "UserPageId", "AdminId", "PageId", "UserId" },
                values: new object[] { new Guid("c71507e1-1996-4c71-9ea6-9590524b29e9"), new Guid("35f701f3-3d03-4c69-b0ec-9688e8abe19e"), new Guid("802d66a4-d17d-4643-810b-9daa62e21ed0"), new Guid("af301fd9-08d8-44ae-a255-6d138c8e000a") });

            migrationBuilder.InsertData(
                table: "UserPages",
                columns: new[] { "UserPageId", "AdminId", "PageId", "UserId" },
                values: new object[] { new Guid("5859ecfc-5aae-4063-aae7-667fcec51f26"), new Guid("f17058d9-46d0-4f42-b28a-1b168a713f50"), new Guid("086410cb-802e-4df1-8094-483af4b264ee"), new Guid("66e9c50e-7994-4301-a5fe-4e29c88432e0") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPages",
                keyColumn: "UserPageId",
                keyValue: new Guid("00ea78cb-8c55-49cb-b1b4-fb23ec5e1780"));

            migrationBuilder.DeleteData(
                table: "UserPages",
                keyColumn: "UserPageId",
                keyValue: new Guid("5859ecfc-5aae-4063-aae7-667fcec51f26"));

            migrationBuilder.DeleteData(
                table: "UserPages",
                keyColumn: "UserPageId",
                keyValue: new Guid("c71507e1-1996-4c71-9ea6-9590524b29e9"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: new Guid("285c1dca-748d-41fc-87fc-4f779afe1d96"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: new Guid("35f701f3-3d03-4c69-b0ec-9688e8abe19e"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: new Guid("f17058d9-46d0-4f42-b28a-1b168a713f50"));

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: new Guid("086410cb-802e-4df1-8094-483af4b264ee"));

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: new Guid("802d66a4-d17d-4643-810b-9daa62e21ed0"));

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: new Guid("98780c10-4a78-4e3d-a219-b08161878402"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("66e9c50e-7994-4301-a5fe-4e29c88432e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("753fd9fb-e3a5-4188-bf3b-95fc0ef6d0b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("af301fd9-08d8-44ae-a255-6d138c8e000a"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "RoleId",
                keyValue: new Guid("1820fb8d-66cf-4a49-adf7-de943ea9e3d7"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "RoleId",
                keyValue: new Guid("1c1f366b-7e15-455d-b193-20520c3d1b20"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "RoleId",
                keyValue: new Guid("60ad944d-a773-426f-a92d-f0e7b9921086"));
        }
    }
}
