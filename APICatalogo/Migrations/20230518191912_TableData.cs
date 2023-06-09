﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class TableData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO categories(Name, ImageUrl) VALUES ('Drinks', 'drinks.jpg')");
            migrationBuilder.Sql("INSERT INTO categories(Name, ImageUrl) VALUES ('Snacks', 'snacks.jpg')");
            migrationBuilder.Sql("INSERT INTO categories(Name, ImageUrl) VALUES ('Dessert', 'desserts.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM categories");
        }
    }
}
