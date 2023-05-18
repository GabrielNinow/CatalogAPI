using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class ProductsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            "INSERT INTO products(Name,Description,Prize,ImageUrl,Quantity,RegistrationDate,CategoryId) VALUES('Coke', 'Soda', '6', 'coke.jpg', '50', NOW(), 1)"
            );
            
            migrationBuilder.Sql(
            "INSERT INTO products(Name,Description,Prize,ImageUrl,Quantity,RegistrationDate,CategoryId) VALUES('Burguer', 'Cheese Burger', '15', 'burguer.jpg', '25', NOW(), 2)"
            );
            
            migrationBuilder.Sql(
            "INSERT INTO products(Name,Description,Prize,ImageUrl,Quantity,RegistrationDate,CategoryId) VALUES('Cheesecake slice', 'Cake', '12', 'cheeseCake.jpg', '20', NOW(), 3)"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM products");
        }
    }
}
